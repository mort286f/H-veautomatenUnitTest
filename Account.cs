using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HæveautomatenUnitTest
{
    public class Account
    {
        public Card Card { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Amount { get; set; }

        public Account(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


        public string GenerateNewCard(string pincode)
        {
            Regex regex = new Regex("^[0-9]+$");
            bool isPinValid = regex.IsMatch(pincode);
            if (isPinValid)
            {
                this.Card = new Card(pincode, this);
                return "card made";
            }
            else if(!isPinValid)
            {
                return "Card was not made. Pincode was invalid";
            }
            else
            {
                return "Card failed to generate";
            }
        }
        public bool Withdraw(double amount)
        {
            if (this.Amount >= amount)
            {
                this.Amount = Amount - amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Deposit(double amount)
        {

            if (this.Amount >= amount)
            {
                this.Amount += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
