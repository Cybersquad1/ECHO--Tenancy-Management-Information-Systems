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
        public List<MonthlyAssociationDue> GetAllPaid()
        {
            return Find(r=>r.Paid >= r.TotalAmount);
        }

        public Guid ProcessPayment(Guid _assocID, decimal _amount)
        {
            try
            {
                var assoc = GetEntity(r => r.ID == _assocID);

                assoc.Paid = assoc.Paid + _amount;

                decimal? total =0;
                
                total = assoc.Balance - _amount;

                if (total < 0)
                    assoc.Balance = 0;
                else
                    assoc.Balance = total;

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

                return newPayment.ID;
            }
            catch
            {
                return Guid.Empty;
            }
        }
        public MonthlyAssociationDue GetSelected (Guid _assocID)
        {
            return GetEntity(r => r.ID == _assocID);
        }

        public List<MonthlyAssociationDue> GetAllUnpaid()
        {
            return Find(r => r.Paid < r.TotalAmount).OrderByDescending(r => r.ChargeDate).ToList();
        }

        public List<MonthlyAssociationDue> GetAllUnpaid(string _unitNo)
        {
            return Find(r=>r.UnitNumber == _unitNo && r.Paid < r.TotalAmount).OrderByDescending(r => r.ChargeDate).ToList();
        }

        public List<MonthlyAssociationDue> GetAll(string _unitNo)
        {
            return Find(r => r.UnitNumber == _unitNo).OrderBy(r=>r.ChargeDate).ToList();
        }

        public MonthlyAssociationDue GetPreviousBilling(string _unitNo)
        {
            var prevBilling = Find(r => r.UnitNumber == _unitNo && r.Balance > 0);

            prevBilling = prevBilling.OrderByDescending(r => r.ChargeDate).ToList();

            var temp = prevBilling.FirstOrDefault(r => r.Balance > 0);

            if(prevBilling != null)
            {
                return temp;
            }

            return null;
        }

        public Guid CreateMonthlyAssoc(MonthlyAssociationDue _monthlyAssocDue)
        {
            try
            {
               

                var water = new WaterBillingViewModel().GetPrevBilling(_monthlyAssocDue.UnitNumber);

                if(water != null)
                {
                    var vm = new WaterBillingViewModel();

                    vm.UpdateWater(water.ID);
                }

                Add(_monthlyAssocDue);

                return _monthlyAssocDue.ID;
            }
            catch(Exception r)
            {
                return Guid.Empty;
            }
        }
    }
}
