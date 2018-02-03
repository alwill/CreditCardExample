using System;
using System.Collections.Generic;

namespace CreditInterestHelper
{
    /// <summary>
    /// The Person Interface
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Gets or sets the wallets.
        /// </summary>
        /// <value>The wallets.</value>
        IEnumerable<IWallet> Wallets { get; set; }

        /// <summary>
        /// Retrieves the interest for person.
        /// </summary>
        /// <returns>The interest for person.</returns>
        decimal RetrieveInterestForPerson();
    }
}
