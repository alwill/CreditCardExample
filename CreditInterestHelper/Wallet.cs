using System;
using System.Collections.Generic;
using System.Linq;

namespace CreditInterestHelper
{
    public class Wallet : IWallet
    {
        public IEnumerable<ICreditCard> CreditCards { get; set; }

        public Wallet(params ICreditCard[] creditCards)
        {
            CreditCards = creditCards;
        }

        public decimal RetrieveInterestForWallet() 
        {
            decimal totalInterest = 0;

            CreditCards.ToList().ForEach(card =>
            {
                totalInterest += card.CalculateInterest();
            });

            return totalInterest;
        }
    }
}
