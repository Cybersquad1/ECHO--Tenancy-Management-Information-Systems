using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public class UnitViewModel : ViewModelBase<UnitProfile>
    {
        public bool Save(UnitProfile unitProfile)
        {
            try
            {
                //update unit profile info
                var unit = GetEntity(r => r.UnitNumber == unitProfile.UnitNumber);

                unit.StartOfOccupancy = unitProfile.StartOfOccupancy;
                unit.ExpectedEndOfOccupancy = unitProfile.ExpectedEndOfOccupancy;
                unit.NatureOfOccupancy = unitProfile.NatureOfOccupancy;
                unit.Tenant = unitProfile.Tenant;

                Update(unit);
                //end of unit update

                //update tenant profile info

                var db = new EchoEntities();
                var tenant = db.TenantProfile.FirstOrDefault(r => r.ID == unitProfile.Tenant) ;
                tenant.NatureOfOccupancy = unitProfile.NatureOfOccupancy;
                tenant.UnitNumber = unitProfile.UnitNumber;

                db.Entry(tenant).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                //end of update tenant

                //Save Archive
                var archiveVM = new TenantArchiveViewModel();
                archiveVM.SaveArchive(unit);
                //end of archive


                return true;
            }
            catch
            {
                return false;
            }
        }

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
