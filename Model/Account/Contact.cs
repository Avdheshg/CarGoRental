using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Account
{
    public class Contact
    {
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string Address {  get; set; }
        public PersonalInfo PersonalInfo { get; set; }
    }
}
