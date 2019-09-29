using System;

namespace _2019Test.Patterns
{
    public enum Name
    {
        Firstname,
        Lastname,
    }

    public enum Pattern
    {
        English,
        Hebrew,
        HeSpanic,
    }

    public enum PatternAlgorithm
    {
        Sparse, 
        Complex,
    }

    internal class PatternMatching
    {
        /// <summary>
        /// Simple pattern matching between several variabels
        /// </summary>
        public void TryPatternMatching()
        {
            var namePattern = Name.Firstname;
            var languagePattern = Pattern.English;

            switch (namePattern, languagePattern)
            {
                case (Name.Firstname, Pattern.English):
                    Console.WriteLine("Pattern is english, and inspection in firstname");
                    break;
                case (Name.Lastname, Pattern.Hebrew):
                    break;
            }
        }

        /// <summary>
        /// Here we see the power of pattern matching by applying an algorithm 
        /// we need to select out based on a set of mixed possible options. The idea
        /// here that english is capable of a more complex algorithm whereas Hebrew 
        /// currently only supports the sparse algorithm
        /// </summary>
        /// <returns></returns>
        public PatternAlgorithm GetAlgorithmByPatternMatch()
        {
            var namePattern = Name.Firstname;
            var languagePattern = Pattern.English;

            var algorithm = (namePattern, languagePattern) switch
            {
                (Name.Firstname, Pattern.English) => PatternAlgorithm.Complex,
                (Name.Lastname, Pattern.English) => PatternAlgorithm.Complex,
                (Name.Firstname, Pattern.Hebrew) => PatternAlgorithm.Sparse,
            };

            return algorithm;
        }
    }
}
