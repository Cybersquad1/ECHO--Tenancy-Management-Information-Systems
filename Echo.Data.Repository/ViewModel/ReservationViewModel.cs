using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public class ReservationViewModel : ViewModelBase<Reservation>
    {
        public List<Reservation> GetAll(string _unitNo)
        {
            return Find(r => r.UnitNumber == _unitNo).OrderByDescending(r => r.Date).ToList();
        }
        public bool ProcessPaymenet(Guid _reservationID, decimal _amount)
        {
            try
            {
                var reservation = GetEntity(r => r.ID == _reservationID);

                reservation.Paid = reservation.Paid + _amount;

                reservation.Balance = reservation.Balance - _amount;

                Update(reservation);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public Reservation GetSelected (Guid _reservationID)
        {
            return GetEntity(r => r.ID == _reservationID);
        }

        public bool Save(Reservation _reservation)
        {
            try
            {
                Add(_reservation);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Reservation> GetAllUnpaid(string _unitNo)
        {
            return Find(r => r.Balance > 0 && r.UnitNumber == _unitNo);
        }

        public bool CheckIfAvailable(string _facility, DateTime _date)
        {
            var reservation = GetEntity(r => r.Facility == _facility && 
            r.DateOfFuntion.ToShortDateString() == _date.ToShortDateString());

            if (reservation != null)
                return false;
            else
                return true;
        }
    }
}
