using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveautomatenUnitTest
{
    class ATMMachine
    {
        public string Withdraw(string pincode, double amount, Card card)
        {
            if (card.Pincode == pincode)
            {
                return card.Withdraw(amount, pincode);
            }
            return "Withdrawal went wrong. Try again";
        }

        public string Deposit(string pincode, double amount, Card card)
        {
            if (card.Pincode == pincode)
            {
                return card.Deposit(amount, pincode);
            }
            return "Deposit went wrong. Try again";
        }
    }
}
