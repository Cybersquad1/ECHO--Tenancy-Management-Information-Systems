using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
   public class TenantViewModel : ViewModelBase<TenantProfile>
    {
        public TenantProfile GetSelectedTenant(Guid? _tenantID)
        {
            return GetEntity(r => r.ID == _tenantID);
        }
    }
}
