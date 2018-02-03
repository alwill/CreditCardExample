using System;
using CreditInterestHelper;
using Xunit;

namespace CreditInterestHelperTests
{
    public class RequiredTestCases
    {
        [Fact]
        public void RetrieveInterestForWallets_OnePersonOneWalletThreeCards_ReturnsInterest()
        {
            ICreditCard masterCard = new MasterCard(100);
            ICreditCard discoverCard = new Discover(100);
            ICreditCard visaCard = new Visa(100);
            IWallet wallet = new Wallet(discoverCard, masterCard, visaCard);
            IPerson person = new Person(wallet);

            decimal totalInterest = person.RetrieveInterestForWallets();

            Assert.Equal(16, totalInterest);
        }
    }
}
