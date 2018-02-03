using System;
namespace CreditInterestHelper
{
    public class Visa : ICreditCard
    {
        public decimal InterestRate { get; set; } = 0.1m;
        public decimal Balance { get; set; }

        public Visa(decimal amount)
        {
            Balance = amount;
        }

        public Visa(decimal interestRate, decimal amount)
        {
            Balance = amount;
            InterestRate = interestRate;
        }
    }
}
