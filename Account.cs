using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Day2_Inkapsulation
{
    public class Account
        {
            private decimal balance;
            public AccountOwner Owner { get; private set; }
            public AccountAdmin Admin { get; private set; }

            public Account(AccountOwner owner, AccountAdmin admin, decimal initialBalance)
            {
                Owner = owner;
                Admin = admin;
                balance = initialBalance < 100 ? 100 : initialBalance;
            }

            public string Deposit(decimal amount)
            {
                balance += amount;
            return $"Din konto er blevet opdateret. Der står nu kr. {balance}";
            }

            public string Withdraw(decimal amount)
            {
                if (amount > balance)
                {
                    return "Insufficient funds.";
                }
                balance -= amount;
            return $"Din konto er blevet opdateret. Der står nu kr. {balance}";
            }

            public decimal GetBalance()
            {
                return balance;
            }
        }
}
