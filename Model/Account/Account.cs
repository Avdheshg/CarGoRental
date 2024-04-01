using System;

namespace CarGoRental.Model.Account
{
    /*
    3 kind person are going to use Account: Admin, Driver, User

    All 3 have different functions to perform:
        * Admin : Can change the AccountStatus of the user
                  Can add or remove vehicles 
        * Driver: Can accept or reject the reservation

        * User: Create, cancel ride

    */
    public abstract class Account
    {   
        private string _id = (Guid.NewGuid()).ToString();
        private AccountType _accountType;
        private Contact _contact;

        public string Id => _id;
        public string OldPassword {  get; set; }
        public string Password { get; set; }
        public DateTime LastAccessed {  get; set; }
        public Contact Contact => _contact;
        public AccountStatusType AccountStatusType { get; set; }
        public AccountType AccountType => _accountType;

        protected Account(string fullName, string email, string password, string phone, string address)
        {
            string[] firstAndLastName = fullName.Split(" ");
            var personalInfo = new PersonalInfo()
            {
                FirstName = firstAndLastName[0],
                LastName = firstAndLastName[1],
            };

            _contact = new Contact()
            {
                Phone = phone,
                Email = email,
                Address = address
            };

            Password = password;
            //_accountType = accountType;    // Get account type from the 2nd screen
            LastAccessed = DateTime.Now;
            AccountStatusType = AccountStatusType.ACTIVE;
        }

    }
}
