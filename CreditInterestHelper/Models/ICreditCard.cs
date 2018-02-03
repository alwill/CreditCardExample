using System;

namespace CreditInterestHelper
{
    /// <summary>
    /// Holds info for a credit card.
    /// </summary>
    public interface ICreditCard
    {
        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>The balance.</value>
        decimal Balance { get; set; }

        /// <summary>
        /// Gets or sets the interest rate.
        /// Could be private readonly but my assumption is the interest
        /// rate for a card could change after startup.
        /// </summary>
        /// <value>The interest rate.</value>
        decimal InterestRate { get; set; }
    }
}
