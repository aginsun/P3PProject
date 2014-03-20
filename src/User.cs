using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P3P
{
    public class User
    {
        string username;
        string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
    }
}