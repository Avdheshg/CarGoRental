using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarGoRental.Model.Account;

namespace CarGoRental.Repository
{
    public class AccountRepository
    {
        private List<Account> accounts = new List<Account>();

        public void CreateNewAccount(Account newAccount)
        {
            accounts.Add(newAccount);
        }

        public void DeleteAccount(string accountId) 
        { 
            var accountToBeDeleted = accounts.FirstOrDefault(account => account.Id.Equals(accountId));
            if (accountToBeDeleted != null)
            {
                accounts.Remove(accountToBeDeleted);
            }

        }

        public void UpdatePassword(string accountId, string newPassword)
        {

        }

        public void UpdateAccountStatusType(string accountId, AccountStatusType accountStatusType)
        {

        }

        public Account GetAccount(string accountId)
        {
            var foundAccount = accounts.FirstOrDefault(account => account.Id.Equals(accountId));

            if (foundAccount != null)
            {
                return foundAccount;
            }

            throw new InvalidOperationException("Account not found.");
        }

    }
}
