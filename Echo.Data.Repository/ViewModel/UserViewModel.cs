
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public class UserViewModel : ViewModelBase<UserProfile>
    { 
        public UserProfile TryLogin(string _username, string _password)
        {
            return GetEntity(user => user.Username == _username && user.Password == _password);          
        }

        public bool DeactivateUser(Guid _userID, string _type)
        {
            try
            {
                var user = GetEntity(r => r.ID == _userID);

                user.Status = _type;

                Update(user);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddUser(UserProfile _user)
        {
            //Default data if new user
            _user.Status = "Y"; //Active Status
            _user.IfGeneratedPassword = "Y";
            _user.FullName = _user.FirstName + " " + _user.LastName;

            try
            {
                Add(_user);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateUser(UserProfile _user)
        {

            _user.FullName = _user.FirstName + " " + _user.LastName;

            try
            {
                Update(_user);

                return true;
            }
            catch(Exception err)
            {
                return false;
            }
        }

        public UserProfile GetSelectedUser(Guid _userID)
        {
            return GetEntity(r => r.ID == _userID);
        }

        public List<UserProfile> GetUsers(string _searchKey)
        {
            return Find(r => r.FullName.ToLower().Contains(_searchKey.ToLower()));
        }

        public List<UserProfile> GetUsers()
        {
            return Find();
        }
    }
}
