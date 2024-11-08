using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Day2_Inkapsulation
{
    public class AccountAdmin : Person
    {
        public string EmployeeId { get; private set; }
        public AccountAdmin(string employeeId, string firstName, string lastName) : base(firstName, lastName)
        {
            if (employeeId.Length != 6)
            {
                EmployeeId = "000000";
                Console.WriteLine("Employee ID must be 6 digits. Setting to default (000000).");
            }
            else
            {
                EmployeeId = employeeId;
            }
        }
    }
}
