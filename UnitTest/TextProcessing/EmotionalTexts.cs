using FluentAssertions;
using Xunit;

namespace UnitTest.TextProcessing
{
    public class EmotionalTexts
    {
        [Fact]
        public void NoComment()
        {
            //arrange
            var text = "هیچ نظر خاصی در مورد این محصول ندارم";
            //act
            var processor = new TestApp.TextProcessing();
            var result=processor.GetFeelings(text);
            
            Assert.Equal(TestApp.TextProcessing.Emotion.Moderate,result);
        }
        
        [Fact]
        public void BadComment()
        {
            //arrange
            var text = "محصول مزخرفی را تولید کردید";
            //act
            var processor = new TestApp.TextProcessing();
            var result=processor.GetFeelings(text);

            result.Should().Be(TestApp.TextProcessing.Emotion.Bad);
        }
        
        [Fact]
        public void GoodComent()
        {
            //arrange
            var text = "آقا محصولتون خیلی عالی بود. دستتون هم درد نکنه";
            //act
            var processor = new TestApp.TextProcessing();
            var result=processor.GetFeelings(text);
            
            Assert.Equal(TestApp.TextProcessing.Emotion.Good,result);
        }
    }
}