using System;
using CreditInterestHelper;
using Xunit;

namespace CreditInterestHelperTests
{
    public class MasterCardTests
    {
        [Fact]
        public void CalculateInterest_ValidBalanceAndInterest_ReturnsInterest()
        {
            ICreditCard masterCard = new MasterCard(0.1m, 100);

            decimal interestOnCard = masterCard.CalculateInterest();

            Assert.Equal(10, interestOnCard);
        }

        [Fact]
        public void CalculateInterest_NegativeBalance_ThowsException() 
        {
            ICreditCard masterCard = new MasterCard(0.1m, -100);

            Assert.Throws<ArgumentOutOfRangeException>(
                () => masterCard.CalculateInterest()
            );
        }
    }
}
