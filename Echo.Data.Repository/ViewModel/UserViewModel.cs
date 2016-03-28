
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

        public void AddUser(UserProfile _user)
        {
            //Default data if new user
            _user.Status = "Y"; //Active Status
            _user.IfGeneratedPassword = "Y";
            _user.FullName = _user.FirstName + " " + _user.LastName;

            Add(_user);
        }

        public void UpdateUser(UserProfile _user)
        {
            if (_user.Password != "")
                _user.IfGeneratedPassword = "Y";

            _user.FullName = _user.FirstName + " " + _user.LastName;

            Update(_user);
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
