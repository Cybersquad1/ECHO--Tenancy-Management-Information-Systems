using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
   public class TenantViewModel : ViewModelBase<TenantProfile>
    {
        public bool ChangePassword(Guid _tenantID, string _newPassword)
        {
            try
            {
                var tenant = GetEntity(r => r.ID == _tenantID);

                tenant.Password = _newPassword;

                Update(tenant);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public TenantProfile TryLogin(string _username, string _password)
        {
            return GetEntity(r => r.Username == _username && r.Password == _password);
        }

        public TenantProfile GetSelectedTenant(Guid? _tenantID)
        {
            return GetEntity(r => r.ID == _tenantID);
        }

        public List<TenantProfile> GetAll(string _status)
        {
            return Find(r=>r.Status == _status);
        }

        public List<TenantProfile> Search(string _searchKey, string _status)
        {
            return Find(r => r.FirstName.ToLower().Contains(_searchKey.ToLower()) ||
                r.LastName.ToLower().Contains(_searchKey.ToLower()) ||
                r.MiddleName.ToLower().Contains(_searchKey.ToLower()) && r.Status == _status);
        }

        public bool ChangeTenantStatus(Guid _tenantID, string _status)
        {
            try
            {
                var tenant = GetSelectedTenant(_tenantID);

                tenant.Status = _status;

                Update(tenant); //Save Changes

                return true;
            }
            catch //just for debugging
            {
                return false;
            }
        }

        public bool AddTenant(TenantProfile _tenantProfile)
        {
            try
            {
                _tenantProfile.Status = "Y"; //Active status       

                Add(_tenantProfile);      

                return true;
            }
            catch
            {
                return false;                                                                                                                                                             
            }
        }
    }
}
