using Microsoft.VisualStudio.TestTools.UnitTesting;
using Accounts;

namespace Accounts.Tests
{
    [TestClass()]
    public class CheckingAccountTests
    {
        [TestMethod()]
        [Timeout(2000)]
        public void Withdraw_ValidAmount_ChangesBalance()
        {
            // Arrange
            double currentBalance = 10.0;
            double amount = 1.0;
            double expected = 9.0;
            var account = new CheckingAccount(currentBalance);

            // Act
            account.Withdraw(amount);

            //Assert
            Assert.AreEqual(expected, account.Balance);
        }

        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void Withdraw_AmountMoreThanBalance_ThrowsException()
        {
            // arrange
            double currentBalance = 10.0;
            var account = new CheckingAccount(currentBalance);

            // act and assert
            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(20.0));
        }
    }
}
