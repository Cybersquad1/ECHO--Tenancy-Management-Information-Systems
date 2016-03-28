using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echo.Data.Repository.ViewModel;

namespace Echo.Data.Repository.Repository
{
    public class LoginInfo
    {
        public string username { get; set; }
        public string fullName { get; set; }
        public string accountType { get; set; }
    }

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

        public List<UserProfile> GetUserList(string _searchKey)
        {
            if (_searchKey != "")
                return GetUsers(_searchKey); //filter list with search parameter
            else
                return GetUsers(); //get all
        }
    }
}
