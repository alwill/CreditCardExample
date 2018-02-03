﻿using System;

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
            if (Balance <= 0) 
            {
                return 0;
            }
            return Balance * InterestRate;
        }
    }
}
