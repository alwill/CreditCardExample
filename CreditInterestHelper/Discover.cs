using System;
namespace CreditInterestHelper
{
    public class Discover : ICreditCard
    {
        public decimal InterestRate { get; set; } = 0.01m;
        public decimal Balance { get; set; }

        public Discover(decimal amount)
        {
            Balance = amount;
        }

        public Discover(decimal interestRate, decimal amount)
        {
            Balance = amount;
            InterestRate = interestRate;
        }

        public decimal CalculateInterest()
        {
            if (Balance <= 0)
            {
                return 0;
            }
            return Balance * InterestRate;
        }
    }
}
