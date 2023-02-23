using Accounts.Models.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Brokers
{
    public interface IStorageBroker
    {
        Account InsertAccount(Account account);
        Account UpdateAccount(Account account);
        void RemoveAccount(Guid id);
    }
}
