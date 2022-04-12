using System;
using System.Linq;

namespace TestApp
{
    public class TextProcessing
    {
        public enum Emotion
        {
            Good,
            Bad,
            Moderate
        }
        public class WordStrength
        {
            public string Word { get; set; }
            public int Strength { get; set; }
        }

        private WordStrength[] words = new[]
        {
            new WordStrength()
            {
                Word = "افتضاح",
                Strength = -5
            },
            new WordStrength()
            {
                Word = "مزخرف",
                Strength = -5
            },
            new WordStrength()
            {
                Word = "بد نبود",
                Strength = 0
            },
            new WordStrength()
            {
                Word = "بد",
                Strength = -2
            },
            new WordStrength()
            {
                Word = "خوب",
                Strength = 2
            },
            new WordStrength()
            {
                Word = "عالی",
                Strength = 4
            },
            new WordStrength()
            {
                Word = "فوق العاده",
                Strength = 5
            }
        };
        
        public Emotion GetFeelings(string text)
        {
            var strength = 0;
            var textWords = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in textWords)
            {
                var find = words.FirstOrDefault(x => word.Contains(x.Word));
                if (find!=null)
                {
                    strength += find.Strength;
                }
            }

            if (strength > 2)
                return Emotion.Good;
            if (strength < -2)
                return Emotion.Bad;
            return Emotion.Moderate;
        }
    }
}