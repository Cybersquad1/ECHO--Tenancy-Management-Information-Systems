using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public class TenantArchiveViewModel : ViewModelBase<TenantArchive>
    {
        public void SaveArchive(UnitProfile unitProfile)
        {
            TenantArchive archive = new TenantArchive
            {
                TenantID = unitProfile.Tenant,
                UnitNumber = unitProfile.UnitNumber,
                StartOfOccupancy = unitProfile.StartOfOccupancy,
                EndOfOccupancy = unitProfile.ExpectedEndOfOccupancy,
                NatureOfOccupancy = unitProfile.NatureOfOccupancy
            };

            Add(archive);
        }
    }
}
