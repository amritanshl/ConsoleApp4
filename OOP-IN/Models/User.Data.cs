using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IN.Models
{
    public partial class User
    {
        private string _password; // Private: Cannot be accessed outside
        public string Username { get; set; }
        public bool IsVerified { get; set; }

        public User(string username, string password)
        {
            Username = username;
            _password = password;
            IsVerified = false;
        }
    }
}
