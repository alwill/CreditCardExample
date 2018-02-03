﻿using System;
using CreditInterestHelper;
using Xunit;

namespace CreditInterestHelperTests
{
    public class PersonTests
    {
        [Fact]
        public void RetrieveInterestForWallets_OneWallet_ReturnsInterest()
        {
            ICreditCard masterCard = new MasterCard(100);
            IWallet wallet = new Wallet(masterCard);
            IPerson person = new Person(wallet);

            decimal totalInterest = person.RetrieveInterestForWallets();

            Assert.Equal(5, totalInterest);
        }

        [Fact]
        public void RetrieveInterestForWallets_MultipleWallets_ReturnsInterest()
        {
            ICreditCard masterCard = new MasterCard(100);
            ICreditCard masterCard2 = new MasterCard(200);
            IWallet wallet = new Wallet(masterCard);
            IWallet wallet2 = new Wallet(masterCard2);
            IPerson person = new Person(wallet, wallet2);

            decimal totalInterest = person.RetrieveInterestForWallets();

            Assert.Equal(15, totalInterest);
        }



        [Fact]
        public void RetrieveInterestForWallets_MultipleWallets_ReturnsZero()
        {
            IPerson person = new Person();

            decimal totalInterest = person.RetrieveInterestForWallets();

            Assert.Equal(0, totalInterest);
        }
    }
}
