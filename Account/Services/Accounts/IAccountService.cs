using Accounts.Brokers;
using Accounts.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Services.Accounts
{
    public interface IAccountService
    {
        Account AddAccount(Account account);
    }

    public class AccountService : IAccountService
    {
        private readonly IStorageBroker _storageBroker;
        public AccountService(IStorageBroker storageBroker)
        {
            _storageBroker = storageBroker;
        }

        //Write Test first (TDD).
        public Account AddAccount(Account account)
        {
            Account storageAccount = _storageBroker.InsertAccount(account);

            return storageAccount;
        }
    }
}
