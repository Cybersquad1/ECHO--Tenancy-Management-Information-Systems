using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echo.Data.Repository.ViewModel;

namespace Echo.Data.Repository.Repository
{
    public class UserRepository : UserViewModel
    {
        public UserProfile Login(string _username, string _password)
        {
            var user = TryLogin(_username, _password);

            if (user != null)
                return user;
            else //if wrong username or password
                return null;
        }

        public bool CreateUser(UserProfile _user)
        {
            try
            {
                AddUser(_user);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
