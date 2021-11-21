using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Bank
    {
        private List<BasicAccount> accounts = new List<BasicAccount>();

        public void AddAccount(BasicAccount account)
        {
            accounts.Add(account);
        }

        public decimal GetValue()
        {
            decimal value = 0;
            foreach (var a in accounts)
            {
                value += a.GetValue();
            }

            return value;
        }
    }
}
