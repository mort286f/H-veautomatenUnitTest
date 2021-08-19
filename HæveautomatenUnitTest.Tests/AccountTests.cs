using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using HæveautomatenUnitTest;

namespace HæveautomatenUnitTest.Tests
{
    public class AccountTests
    {
        [Fact]
        public void Account_SetupAccountShouldMakeNewAccount()
        {
            //Arrange
            Account acc = new Account("Benjamin", "Roesdal");
            acc.GenerateNewCard("5555");

            //Actual


            //Assert
            Assert.NotNull(acc.Card);
        }
    }
}
