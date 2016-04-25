using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public class WaterBillingViewModel : ViewModelBase<WaterBilling>
    {
        public class PreviousBalance
        {
            public DateTime Date { get; set; }
            public decimal Amount { get; set; }
        }

        public string[] GetPreviousBilling(string _unitNo)
        {
            string[] returnValue = null;

            var billing = GetLast(r => r.UnitNumber == _unitNo); //Get last record of Water billing

            if (billing != null)
            {
                returnValue[0] = billing.CurrentReading; //reading
                returnValue[1] = string.Format("{0:0.00}", billing.TotalAmount); //amount
            }

            return returnValue;
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
    }
}
