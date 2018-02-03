using System;

namespace CreditInterestHelper
{
    public class MasterCard : ICreditCard
    {
        public decimal InterestRate { get; set; } = 0.05m;
        public decimal Balance { get; set; }

        public MasterCard(decimal amount) 
        {
            Balance = amount;    
        }

        public MasterCard(decimal interestRate, decimal amount)
        {
            Balance = amount;
            InterestRate = interestRate;
        }

        public decimal CalculateInterest() 
        {
            // These ended up all having the same implementation.
            // It could be refactored out to common code or could have been
            // Abstract class but the implementation could change.
            if (Balance <= 0) 
            {
                return 0;
            }
            return Balance * InterestRate;
        }
    }
}
