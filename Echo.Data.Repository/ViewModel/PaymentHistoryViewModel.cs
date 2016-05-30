using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public class PaymentHistoryViewModel : ViewModelBase<PaymentHistory>
    {
        public void Save(PaymentHistory _paymentHistory)
        {
            try
            {
                Add(_paymentHistory);
            }
            catch
            {}
        }

        public DateTime? GetLastPayment(string _unitNo)
        {
            var lastPayment = GetLast(r => r.UnitNumber == _unitNo);

            if (lastPayment != null)
                return lastPayment.Date;
            else
                return null;
        }
    }
}
