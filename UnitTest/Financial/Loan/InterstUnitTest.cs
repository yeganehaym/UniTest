using FluentAssertions;
using TestApp;
using Xunit;

namespace UnitTest.Financial.Loan
{
    public class InterstUnitTest
    {
        [Fact]
        public void FiveM5Year()
        {
            //arrange
            var amount = 5000000;
            var year = 5;
            var percent = 4;
            
            //act
            var loanFuc = new LoanFunctions();
            var interest=loanFuc.CalculateInterest(amount, year, percent);
            
            //assert
            Assert.Equal(1000000,interest);
        }
        
        [Fact]
        public void FiveM3Year()
        {
            //arrange
            var amount = 5000000;
            var year = 3;
            var percent = 4;
            
            //act
            var loanFuc = new LoanFunctions();
            var interest=loanFuc.CalculateInterest(amount, year, percent);
            
            //assert : https://fluentassertions.com/
            interest.Should().BeGreaterThan(1000);
        }
        
        [Theory]
        [InlineData(5000000,2,4)]
        [InlineData(5000000,5,4)]
        [InlineData(5000000,10,4)]
        [InlineData(5000000,3,4)]
        public void FiveM2Year(int amount,int year,int percent)
        {
       
            
            //act
            var loanFuc = new LoanFunctions();
            var interest=loanFuc.CalculateInterest(amount, year, percent);
            
            //assert : https://fluentassertions.com/
            interest.Should().BeGreaterThan(1000);
        }
        
    }
}