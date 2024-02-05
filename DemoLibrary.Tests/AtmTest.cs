using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using UnitTestTest;
using Xunit;

namespace DemoLibrary.Tests
{
    public class AtmTest
    {
        [Theory]
        [InlineData(1234, 1234)]
        [InlineData(6543, 6543)]
        public void Pinnumber_PinnumberShouldBeEquel(int input, int pin)
        {
            // Arrange
            int expected = pin;

            // Act
            int actual = Atm.Pinnumber(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1234, 12343)]
        [InlineData(6543.25, 65433.75)]
        public void Withdraw_WithdrawShouldBeLessThanAmount(int withdraw, int amount)
        {
            // Arrange
            decimal expetet = amount;

            // Act
            decimal actual = Atm.Withdraw(withdraw, amount);

            //Assert
            Assert.True((decimal)expetet >= actual);
            
        }

    }
}
