namespace _2019Test.Patterns
{
    public class PatternVersion
    {
        public PatternAlgorithm Algorithm { get; private set; }
        public uint SupportedVersion { get; private set; }
        
        public PatternVersion(PatternAlgorithm algorithm, uint supportedVersion) 
        { 
            Algorithm = algorithm; 
            SupportedVersion = supportedVersion; 
        }

        /// <summary>
        /// The deconstruct message is used for external or internal pattern 
        /// matching
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="supportedVersion"></param>
        public void Deconstruct(out PatternAlgorithm algorithm, out uint supportedVersion)
        {
            algorithm = Algorithm;
            supportedVersion = SupportedVersion;
        }

        /// <summary>
        /// Please refer to the previous method. This syntax requires the Deconstruct 
        /// message
        /// </summary>
        /// <param name="patternVersion"></param>
        /// <returns></returns>
        public bool IsComplexAndEnglish(PatternVersion patternVersion) =>
            patternVersion is PatternVersion(PatternAlgorithm.Complex, 20);
    }
}
