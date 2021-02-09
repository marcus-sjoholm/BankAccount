using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount.Controllers;

namespace BankAccount.Controllers.Tests
{
    [TestClass()]
    public class BankTests
    {
        [TestMethod()]
        public void DepositTest()
        {
            var bank = new Bank();
            Assert.IsTrue(bank.Deposit(10000));
            bank.Output();
        }

        [TestMethod()]
        public void WithdrawTest()
        {
            var bank = new Bank();
            Assert.IsTrue(bank.Withdraw(100));
            bank.Output();
        }

        [TestMethod()]
        public void CreditLimitTest()
        {
            var bank = new Bank();
            Assert.IsTrue(bank.CreditLimit(2000));
            bank.Output();
        }

        [TestMethod()]
        public void SwishTest()
        {
            var bank = new Bank();
            Assert.IsTrue(bank.Swish(400));
            bank.Output();
        }

        [TestMethod()]
        public void TransferTest()
        {
            var bank = new Bank();
            Assert.IsTrue(bank.Transfer(500));
            bank.Output();
        }
    }
}