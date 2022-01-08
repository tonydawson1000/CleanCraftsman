using CleanCraftsman;
using Xunit;
using FluentAssertions;

namespace CleanCraftsmanTests
{
    public class PrimeFactorsTest
    {
        [Fact]
        public void Factors()
        {
            //The prime numbers below 20 are: 2, 3, 5, 7, 11, 13, 17, 19.
            //Don't forget: the number 1 is not a prime number as it only has one factor.

            //Arrange
            var primeFactors = new PrimeFactors();

            //Act

            //Assert
            Assert.Empty(primeFactors.FactorsOf(1));

            Assert.Contains(2, primeFactors.FactorsOf(2));  //Prime

            Assert.Contains(3, primeFactors.FactorsOf(3));  //Prime

            primeFactors.FactorsOf(4).Should().ContainInOrder(new[] { 2, 2 });

            Assert.Contains(5, primeFactors.FactorsOf(5));  //Prime

            primeFactors.FactorsOf(6).Should().ContainInOrder(new[] { 2, 3 });

            Assert.Contains(7, primeFactors.FactorsOf(7));  //Prime

            primeFactors.FactorsOf(8).Should().ContainInOrder(new[] { 2, 2, 2 });

            primeFactors.FactorsOf(9).Should().ContainInOrder(new[] { 3, 3 });


            primeFactors.FactorsOf(2*2*3*3*5*7*11*11*13)
                .Should()
                .ContainInOrder(new[] { 2, 2, 3, 3, 5, 7, 11, 11, 13 });
        }
    }
}