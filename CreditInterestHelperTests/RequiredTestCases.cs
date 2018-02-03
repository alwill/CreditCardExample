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

            decimal totalInterestForPerson = person.RetrieveInterestForPerson();

            Assert.Equal(16, totalInterestForPerson);
        }

        [Fact]
        public void RetrieveInterestForWallets_OnePersonTwoWalletsThreeCards_ReturnsInterest()
        {
            ICreditCard masterCard = new MasterCard(100);
            ICreditCard discoverCard = new Discover(100);
            ICreditCard visaCard = new Visa(100);
            IWallet wallet = new Wallet(discoverCard, visaCard);
            IWallet wallet2 = new Wallet(masterCard);
            IPerson person = new Person(wallet, wallet2);

            decimal totalInterestForPerson = person.RetrieveInterestForPerson();

            Assert.Equal(16, totalInterestForPerson);
        }

        [Fact]
        public void RetrieveInterestForWallets_TwoPersonsTwoWalletsFiveCards_ReturnsInterest()
        {
            ICreditCard masterCard = new MasterCard(100);
            ICreditCard discoverCard = new Discover(100);
            ICreditCard visaCard = new Visa(100);
            ICreditCard masterCard2 = new MasterCard(100);
            ICreditCard visaCard2 = new Visa(100);
            IWallet wallet = new Wallet(discoverCard, visaCard, masterCard);
            IWallet wallet2 = new Wallet(masterCard, visaCard);
            IPerson person = new Person(wallet);
            IPerson person2 = new Person(wallet2);

            decimal totalInterestForPersons = person.RetrieveInterestForPerson();
            totalInterestForPersons += person2.RetrieveInterestForPerson();

            Assert.Equal(31, totalInterestForPersons);
        }
    }
}
