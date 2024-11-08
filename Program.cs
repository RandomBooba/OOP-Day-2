using System.Security.Principal;

namespace OOP_Day2_Inkapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountOwner owner = new AccountOwner("123456", "John", "Doe");

            AccountAdmin admin = new AccountAdmin("654321", "Jane", "Smith");

            Account account = new Account(owner, admin, 100m);

            Console.WriteLine($"Hej {owner.FullName}. Din konto er oprettet med {admin.FullName} som admin.");

            Console.WriteLine(account.Deposit(50m));

            Console.WriteLine(account.Withdraw(30m));

            Console.WriteLine($"Din nuværende saldo er kr. {account.GetBalance()}");
        }
    }
}
