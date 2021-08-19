using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveautomatenUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Morten", "Vestergaard");
            ATMMachine atm = new ATMMachine();
            account.Amount = 1000000;
            account.GenerateNewCard("1234");
            Console.WriteLine(atm.Withdraw("1234", 1000000, account.Card));
            Console.Read();
        }
    }
}
