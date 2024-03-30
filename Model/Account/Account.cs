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
        private string _email;
        private string _userName;
        private AccountType _accountType;
        private Contact _contact;

        public string Id => _id;
        public string Email => _email;
        public string UserName => _userName;
        public string OldPassword {  get; set; }
        public string Password { get; set; }
        public DateTime LastAccessed {  get; set; }
        public Contact Contact => _contact;
        public AccountStatusType AccountStatusType { get; set; }
        public AccountType AccountType => _accountType;

        protected Account(string email, string userName, string password, AccountType accountType, Contact contact)
        {
            _email = email;
            _userName = userName;
            Password = password;
            _accountType = accountType;
            LastAccessed = DateTime.Now;
            _contact = contact;
            AccountStatusType = AccountStatusType.ACTIVE;
        }

    }
}
