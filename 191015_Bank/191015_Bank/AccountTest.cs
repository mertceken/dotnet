using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191015_Bank
{
    [TestFixture]
    class AccountTest
    {
        Account source;
        Account destination;

        [SetUp]
        public void InitAccount()
        {
            source = new Account();
            source.Deposit(200.00F);

            destination = new Account();
            destination.Deposit(150.00F);

        }

        [Test]
        [Category("pass")]
        public void TransferFunds()
        {
            source.TransferFunds(destination, 100.00F);

            Assert.AreEqual(250.00F, destination.Balance);

        }

        [Test, Category("pass")]
        [TestCase(200, 0, 78)]
        [TestCase(200, 0, 189)]
        [TestCase(200, 0, 1)]

        public void TransferMinFunds(int a, int b, int c)
        {
            Account source = new Account();
            source.Deposit(a);
            Account destination = new Account();
            destination.Deposit(b);

            source.TransferMinFunds(destination, c);
            Assert.AreEqual(c, destination.Balance);

        }

        [Test]
        [Category("fail")]
        [TestCase(500,250,300)]
        [TestCase(500, 250, 500)]
        [TestCase(500, 250, 700)]
        [TestCase(500, 250, 1000)]
        public void TransferMinFundsFail(int a, int b,int c)
        {
            Account source = new Account();
            source.Deposit(a);
            Account destination = new Account();
            destination.Deposit(b);

            source.TransferMinFunds(destination, c);
            Assert.AreEqual(c, destination.Balance);
        }
    }
}
