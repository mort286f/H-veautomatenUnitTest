using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HæveautomatenUnitTest;
using Xunit;

namespace HæveautomatenUnitTest.Tests
{
    public class CardTests
    {
        [Fact]
        public void Card_ValidateWithdrawInputShouldWork()
        {
            //Arrange
            double amount = 1000;
            string pincode = "1234";
            int expected = 9000;

            //Actual
            Account acc = new Account("Alexandar", "lackovic");
            acc.Amount = 10000;
            Card card = new Card("1234", acc);
            card.Withdraw(amount, pincode);
            double actual = acc.Amount;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Card_WithdrawShouldReturnWrongPin()
        {
            //Arrange
            double amount = 1000;
            string pincode = "9999";
            string expected = "Wrong pincode";

            //Actual
            Account acc = new Account("Alexandar", "lackovic");
            acc.Amount = 10000;
            Card card = new Card("1234", acc);
            string actual = card.Withdraw(amount, pincode);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Card_WithdrawNotEnoughAccountMoney()
        {
            //Arrange
            double amount = 10001;
            string pincode = "1234";
            string expected = "withdrawal failed";

            //Actual
            Account acc = new Account("Alexandar", "lackovic");
            acc.Amount = 10000;
            Card card = new Card("1234", acc);
            string actual = card.Withdraw(amount, pincode);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
