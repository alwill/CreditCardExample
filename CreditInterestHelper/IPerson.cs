using System;
using System.Collections.Generic;

namespace CreditInterestHelper
{
    public interface IPerson
    {
        IEnumerable<IWallet> Wallets { get; set; }

        decimal RetrieveInterestForWallets();
    }
}
