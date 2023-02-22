using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Models.Accounts
{
    public sealed class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
    }
}
