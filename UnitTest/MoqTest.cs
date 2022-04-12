using FluentAssertions;
using Moq;
using TestApp;
using Xunit;

namespace UnitTest
{
    public class MoqTest
    {
        [Fact]
        public void TestLoanValues()
        {
            //arrang
            var mock = new Mock<WebReader>();
                
            mock.Setup(x => x.GetNumbers())
            .Returns(new int[] {6000000,5,18});
            var values = mock.Object.GetNumbers();
            
            //act
            var loaner = new LoanFunctions();
            var actual = loaner.CalculateInterest(values[0], values[1], values[2]);
            
            //assert
            actual.Should().Be(5400000);


        }
        
        [Theory]
        [InlineData(6000000,5,18)]
        [InlineData(6000000,5,14)]
        [InlineData(6000000,5,20)]
        [InlineData(6000000,5,15)]
        public void TestLoanValuesWithTheory(int amount,int year,int percent)
        {
            //arrang
            var mock = new Mock<WebReader>();
                
            mock.Setup(x => x.GetNumbers())
                .Returns(new int[] {amount,year,percent});
            var values = mock.Object.GetNumbers();
            
            //act
            var loaner = new LoanFunctions();
            var actual = loaner.CalculateInterest(values[0], values[1], values[2]);
            
            //assert
            actual.Should().BeGreaterThan(100000);


        }
    }
}