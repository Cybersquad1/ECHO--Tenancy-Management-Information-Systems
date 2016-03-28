using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenancy_Management_Information_Systems.Utilities
{
    public class UserUtilities
    {
        public string GenerateUsername(string _firstName, string _lastName, string _middleName)
        {
            string username = "";

            string[] fName = _firstName.Split(' ');

            foreach(var item in fName)//Get initials of first name
            {
                username += item.Substring(0, 1).ToUpper();
            }

            if (_middleName != "")
                username += _middleName.Substring(0, 1).ToUpper();

            username += _lastName;

            return username;
        }

        public string GeneratePassword(int _size)
        {
            Random rd = new Random();

            const string allowedChars = 
                "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789!@$?_-";

            char[] chars = new char[_size];

            for (int i = 0; i < _size; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
    }
}

