using System;

namespace _2019Test.Patterns
{
    public class PatternExample
    {
        public void TryMeOut()
        {
            var patternMatch = new PatternMatching();
            var algorithm = patternMatch.GetAlgorithmByPatternMatch();

            var patternVersion = new PatternVersion(algorithm, 20);

            if (patternVersion is PatternVersion(PatternAlgorithm.Complex, 20))
            {
                Console.WriteLine("We have a matching pattern");
            }
        }
    }
}
