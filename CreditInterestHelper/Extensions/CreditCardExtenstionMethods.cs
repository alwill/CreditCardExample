using System;
namespace CreditInterestHelper
{
    public static class CreditCardExtenstionMethods
    {
        /// <summary>
        /// Calculates the simple interest.
        /// </summary>
        /// <returns>The simple interest.</returns>
        /// <param name="creditCard">Credit card.</param>
        public static decimal CalculateSimpleInterest(this ICreditCard creditCard)
        {
            return creditCard.Balance <= 0 ? 
                             0 : 
                             creditCard.Balance * creditCard.InterestRate;
        }
    }
}
