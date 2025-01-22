using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_interface
{
    internal interface IAuthenticationService
    {


        public bool AuthenticateUser(string username, int password);
        public bool AuthorizeUser(string username, string role);
    }
    class BasicAuthenticationService : IAuthenticationService
    {



        public bool AuthenticateUser(string username, int password)
        {
            if (username == "mohamed" && password == 010688)
                return true;
            return false;

        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == "mohamed" && role == "admain")
                return (true);
            return false;

        }
    }
}
