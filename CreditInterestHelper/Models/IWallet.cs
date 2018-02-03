using System;
using System.Collections.Generic;

namespace CreditInterestHelper
{
    public interface IWallet
    {
        /// <summary>
        /// Gets or sets the credit cards.
        /// </summary>
        /// <value>The credit cards.</value>
        IEnumerable<ICreditCard> CreditCards { get; set; }

        /// <summary>
        /// Retrieves the interest for wallet.
        /// </summary>
        /// <returns>The interest for wallet.</returns>
        decimal RetrieveInterestForWallet();
    }
}
