using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HæveautomatenUnitTest
{
    public class Card
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pincode { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Cvc { get; set; }
        public Account Account { get; set; }

        public Card(string pincode, Account account)
        {
            this.Pincode = pincode;
            this.ExpireDate = DateTime.Now.AddYears(5);
            this.CardNumber = GenerateCardNumber();
            this.Cvc = GenerateCvc();
            this.Account = account;
        }

        public string GenerateCardNumber()
        {

            Random rndm = new Random();
            for (int i = 0; i < 16; i++)
            {
                this.CardNumber += rndm.Next(10).ToString();
            }
            return this.CardNumber;
        }

        public string GenerateCvc()
        {
            Random rndm = new Random();
            for (int i = 0; i < 3; i++)
            {
                this.Cvc += rndm.Next(10).ToString();
            }
            return this.Cvc;
        }

        public string Withdraw(double amount, string pincode)
        {
            if (pincode == this.Pincode)
            {
                if (Account.Withdraw(amount))
                {
                    return "Withdrawal successful: " + amount + " withdrawed";
                }
            }
            else if (pincode != Pincode)
            {
                return "Wrong pincode";
            }
            return "withdrawal failed";
        }

        public string Deposit(double amount, string pincode)
        {
            if (pincode == this.Pincode)
            {
                if (Account.Deposit(amount))
                {
                    return "Deposit successful. " + amount + " deposited.";
                }
            }
            else if (pincode != this.Pincode)
            {
                return "Wrong pincode";
            }
            return "Deposit failed";
        }
    }
}
