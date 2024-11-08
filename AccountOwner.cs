using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Day2_Inkapsulation
{
    public class AccountOwner : Person
    {
        public string CustomerId { get; private set; }
        public AccountOwner(string customerId, string firstName, string lastName) : base(firstName, lastName)
        {
            if (customerId.Length != 6)
            {
                CustomerId = "000000";
                Console.WriteLine("Customer ID must be 6 digits. Setting to default (000000).");
            }
            else
            {
                CustomerId = customerId;
            }
        }
    }
}
