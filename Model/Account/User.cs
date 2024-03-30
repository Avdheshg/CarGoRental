using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Account
{
    public class User : Account
    {
        public User(string email, string userName, string password, Contact contactDetails)
            : base(email, userName, password, AccountType.ADMIN, contactDetails)
        {
            
        }
    }
}
