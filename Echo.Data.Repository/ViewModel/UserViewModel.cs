
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
            _user.Status = "Y"; //Active Status

            Add(_user);
        }
    }
}
