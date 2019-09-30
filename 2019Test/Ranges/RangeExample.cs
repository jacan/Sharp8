using System;

namespace _2019Test.Ranges
{
    public class RangeExample
    {
        public void TrySimpleExample()
        {
            var someString = "This is a simple string with a fair amount characters";

            var subString = someString.Substring(10, 6);
            Console.WriteLine(subString);

            var rangedSubString = someString[10..16];
            Console.WriteLine(rangedSubString);

            var rangedStringToEndIndex = someString[..10];
            Console.WriteLine(rangedStringToEndIndex);

            var rangedAllFromStartIndex = someString[10..];
            Console.WriteLine(rangedAllFromStartIndex);
            
        }
    }
}
