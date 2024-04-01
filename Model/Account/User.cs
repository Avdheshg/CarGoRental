using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Account
{
    public class User : Account
    {
        public User(string fullName, string email, string password, string phone, string address)
            : base(fullName, email, password, phone, address)
        {
            
        }
    }
}
