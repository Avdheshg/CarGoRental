using CarGoRental.Repository;
using CarGoRental.Model.Account;
using System;

namespace CarGoRental.Service
{
    /*
    Functions of AccountService
        1. Create a new account
        2. Delete account
        3. Update account - password, accountStatusType
        4. 
    */
    public class AccountService
    {
        private AccountRepository _accountRepository;

        public void CreateNewAccount(Account newAccount)
        {
            _accountRepository.CreateNewAccount(newAccount);
        }

        public void DeleteAccount(string accountId)
        {
            _accountRepository.DeleteAccount(accountId);
        }

        public void UpdatePassword(string accountId, string oldEnteredPassword, string newPassword)
        {
            var account = GetAccount(accountId);
            if (string.IsNullOrEmpty(newPassword) == false && oldEnteredPassword.Equals(account.OldPassword) && oldEnteredPassword.Equals(newPassword) == false ) 
            {
                _accountRepository.UpdatePassword(accountId, newPassword);
            }
        }

        public void UpdateAccountStatusType(string accountId, AccountStatusType accountStatusType)
        {
            _accountRepository.UpdateAccountStatusType(accountId, accountStatusType);
        }

        private Account GetAccount(string accountId)
        {
            return _accountRepository.GetAccount(accountId);
        }

    }
}
