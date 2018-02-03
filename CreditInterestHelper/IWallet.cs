using System;
using System.Collections.Generic;

namespace CreditInterestHelper
{
    public interface IWallet
    {
        IEnumerable<ICreditCard> CreditCards { get; set; }

        decimal RetrieveInterestForWallet();
    }
}
