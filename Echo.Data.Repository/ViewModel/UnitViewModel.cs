using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public class UnitViewModel : ViewModelBase<UnitProfile>
    {
        public bool TransferOwnership(string _unitNo, Guid _newOwnerID)
        {
            try
            {
                var unit = GetEntity(r => r.UnitNumber == _unitNo);

                unit.Owner = _newOwnerID;

                Update(unit);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<UnitProfile> GetAll()
        {
            return Find(); //Get all unit
        }

        public UnitProfile GetSelected(string _unitNo)
        {
            return GetEntity(r => r.UnitNumber == _unitNo);
        }
    }
}
