using System;
using System.Collections.Generic;
using System.Linq;

namespace CreditInterestHelper
{
    public class Person : IPerson
    {
        public IEnumerable<IWallet> Wallets { get; set; }

        public Person(params IWallet[] wallets)
        {
            Wallets = wallets;
        }

        public decimal RetrieveInterestForWallets()
        {
            decimal totalInterest = 0;

            Wallets.ToList().ForEach(wallet =>
            {
                totalInterest += wallet.RetrieveInterestForWallet();
            });

            return totalInterest;
        }
    }
}
