using System;
namespace CreditInterestHelper.Utility
{
    public interface IInterestCalculator
    {
        /// <summary>
        /// Calculates the simple interest.
        /// </summary>
        /// <returns>The simple interest.</returns>
        /// <param name="interestRate">Interest rate.</param>
        /// <param name="amount">Amount to calculate interest against.</param>
        decimal CalculateSimpleInterest(decimal interestRate, decimal amount);
    }
}
