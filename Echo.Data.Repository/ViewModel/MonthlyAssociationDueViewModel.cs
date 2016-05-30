using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echo.Data.Repository;

namespace Echo.Data.Repository.ViewModel
{
    public class MonthlyAssociationDueViewModel: ViewModelBase<MonthlyAssociationDue>
    {
        public bool ProcessPayment(Guid _assocID, decimal _amount)
        {
            try
            {
                var assoc = GetEntity(r => r.ID == _assocID);

                assoc.Paid = assoc.Paid + _amount;

                assoc.Balance = assoc.Balance - _amount;

                Update(assoc);

                //Assign value for payment history
                var paymentVM = new PaymentHistoryViewModel();

                PaymentHistory newPayment = new PaymentHistory();

                newPayment.MonthlyAssocID = _assocID;

                newPayment.Payable = assoc.Balance;

                newPayment.Balance = assoc.Balance - _amount;

                newPayment.TotalPayment = _amount;

                newPayment.Date = DateTime.Now;

                newPayment.Type = "ASSOC";

                newPayment.UnitNumber = assoc.UnitNumber;

                newPayment.ChargeDate = assoc.ChargeDate;

                paymentVM.Save(newPayment); //Save payment history

                return true;
            }
            catch
            {
                return false;
            }
        }
        public MonthlyAssociationDue GetSelected (Guid _assocID)
        {
            return GetEntity(r => r.ID == _assocID);
        }
        public List<MonthlyAssociationDue> GetAllUnpaid(string _unitNo)
        {
            return Find(r=>r.UnitNumber == _unitNo && r.Paid < r.TotalAmount).OrderByDescending(r => r.ChargeDate).ToList();
        }

        public List<MonthlyAssociationDue> GetAll(string _unitNo)
        {
            return Find(r => r.UnitNumber == _unitNo).OrderByDescending(r=>r.ChargeDate).ToList();
        }

        public MonthlyAssociationDue GetPreviousBilling(string _unitNo)
        {
            var prevBilling = GetLast(r => r.UnitNumber == _unitNo);

            if(prevBilling != null)
            {
                return prevBilling;
            }

            return null;
        }

        public Guid CreateMonthlyAssoc(MonthlyAssociationDue _monthlyAssocDue)
        {
            try
            {
                Add(_monthlyAssocDue);

                return _monthlyAssocDue.ID;
            }
            catch
            {
                return Guid.Empty;
            }
        }
    }
}
