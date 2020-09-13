using System;
using System.Collections.Generic;

namespace CodewarsTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IEnumerable<string> words1 = new List<string> { "javascript", "java", "ruby", "php", "python", "coffeescript" };
            IEnumerable<string> words2 = new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" };
            IEnumerable<string> words3 = new List<string> { "zqdrhpviqslik", "hirldidcuzbyb", "karpscdigdvucfr", "pppppprrrr" };

            WhatIsThisWord test1 = new WhatIsThisWord(words1);
            WhatIsThisWord test2 = new WhatIsThisWord(words2);
            WhatIsThisWord test3 = new WhatIsThisWord(words3);

            //Console.WriteLine($"Expected result: java - Actual Output: {test1.FindMostSimilar("heaven")} ");
            //Console.WriteLine();
            //Console.WriteLine($"Expected result: javascript - Actual Output: {test1.FindMostSimilar("javascript")} ");
            //Console.WriteLine();
            //Console.WriteLine($"Expected result: strawberry - Actual Output: {test2.FindMostSimilar("strawbery")} ");
            //Console.WriteLine();
            //Console.WriteLine($"Expected result: cherry - Actual Output: {test2.FindMostSimilar("berry")} ");
            Console.WriteLine();
            Console.WriteLine($"Expected result: zqdrhpviqslik - Actual Output: {test3.FindMostSimilar("rkacypviuburk")} ");
        }

        //Run this function when you want to test many different cases.
        private static void RunTests()
        {
           List<TestCase> tests = new List<TestCase>
            {
                new TestCase(1, "1"),
                new TestCase(5, "120"),
                new TestCase(9, "362880"),
                new TestCase(15, "1307674368000")
            };

            foreach (TestCase test in tests)
            {
                test.SetResultAndCompare(LargeFactorials.Factorial((int)test.Input));
            }
        }
    }
}