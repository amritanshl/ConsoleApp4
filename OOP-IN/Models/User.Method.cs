using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_IN.Models
{
    public partial class User
    {
        public bool Login(string inputPass)
        {
            // Accessing private variable _password from the other file is allowed!
            if (inputPass == _password)
            {
                Console.WriteLine($"Welcome back, {Username}!");
                return true;
            }
            Console.WriteLine("Wrong Password!");
            return false;
        }
    }
}
