using System;
using CreditInterestHelper;
using Xunit;

namespace CreditInterestHelperTests
{
    public class WalletTests
    {
        [Fact]
        public void RetrieveInterestForWallet_OneCreditCard_ReturnsInterest()
        {
            ICreditCard masterCard = new MasterCard(100);
            IWallet wallet = new Wallet(masterCard);

            decimal totalInterest = wallet.RetrieveInterestForWallet();

            Assert.Equal(5, totalInterest);
        }

        [Fact]
        public void RetrieveInterestForWallet_MultipleCreditCard_ReturnsInterest()
        {
            ICreditCard masterCard = new MasterCard(100);
            ICreditCard masterCard2 = new MasterCard(200);
            IWallet wallet = new Wallet(masterCard, masterCard2);

            decimal totalInterest = wallet.RetrieveInterestForWallet();

            Assert.Equal(15, totalInterest);
        }

        [Fact]
        public void RetrieveInterestForWallet_NoCreditCard_ReturnsZero()
        {
            IWallet wallet = new Wallet();

            decimal totalInterest = wallet.RetrieveInterestForWallet();

            Assert.Equal(0, totalInterest);
        }
    }
}
