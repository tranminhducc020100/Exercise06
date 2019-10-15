using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestMethodAccount()
        {
            Account acc = new Account(200000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.Balance());
        }
        public void TestMethodDeposit()
        {
            Account acc = new Account(500000);
            acc.Deposit(200000);
            Assert.AreEqual(700000, acc.Balance());
           
        }
        public void TestMethodWithdraw()
        {
            Account acc = new Account(500000);
            acc.Withdraw(200000);
            Assert.AreEqual(300000, acc.Balance());
            

        }
    }
}
