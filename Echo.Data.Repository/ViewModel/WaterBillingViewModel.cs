using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public class WaterBillingViewModel : ViewModelBase<WaterBilling>
    {
        public void UpdateWater(Guid ID)
        {
            var water = GetEntity(r => r.ID == ID);

            water.Paid = 1;

            Update(water);
        }
        public class PreviousBalance
        {
            public DateTime Date { get; set; }
            public decimal Amount { get; set; }
        }

        public List<WaterBilling> GetAll(string _unitNo)
        {
            return Find(r => r.UnitNumber == _unitNo).OrderByDescending(r => r.ChargeDate).ToList();
        }

        public bool IfBillingAlreadyExist(string _unitNo)
        {
            var billing = GetLast(r=>r.UnitNumber == _unitNo);

            if (billing != null)
            {
                DateTime billingDate = DateTime.Parse(billing.ChargeDate.ToString());

                if(billingDate.Month == DateTime.Now.Month)
                {
                    return true; //Duplicate billing for this month
                }
            }

            return false; //No duplicate billing for this month
        }

        public WaterBilling GetPrevBilling(string _unitNo)
        {
            return GetLast(r => r.UnitNumber == _unitNo);
        }

        public string[] GetPreviousBilling(string _unitNo)
        {
            string[] returnValue = new string[2];

            var billing = GetLast(r => r.UnitNumber == _unitNo); //Get last record of Water billing

            if (billing != null)
            {
                returnValue[0] = billing.CurrentReading; //reading
                returnValue[1] = string.Format("{0:0.00}", billing.TotalAmount); //amount

                return returnValue;
            }

            return null;
        }

        public List<PreviousBalance> GetPreviousBalance(string _unitNo)
        {
            List<PreviousBalance> returnValue = new List<PreviousBalance>();

            //Get all water billing that has remaining balance
            var balance = Find(r => r.UnitNumber == _unitNo && r.Balance > 0).OrderBy(r => r.ChargeDate);

            balance.ToList().ForEach(item =>
            {
                PreviousBalance temp = new PreviousBalance
                {
                    Date = DateTime.Parse(item.ChargeDate.ToString()),
                    Amount = decimal.Parse(item.Balance.ToString())
                };

                returnValue.Add(temp);
            });

            return returnValue;
        }

        public bool CreateWaterBilling(WaterBilling _waterBilling)
        {
            try
            {
                Add(_waterBilling);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
