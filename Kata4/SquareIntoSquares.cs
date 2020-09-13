using System;
using System.Collections.Generic;

namespace CodewarsTest
{
    class SquareIntoSquares
    {
        public static string Decompose(long n)
        {
            return FindOtherRoots(n * n, n - 1); 
        }

        private static string FindOtherRoots(long remainder, long number)
        {
            for (long i = number; i > 0; --i)
            {
                Console.WriteLine(i);
                long square = i * i;
                if (square == remainder)
                {
                    return i.ToString();
                }
                if (square < remainder)
                {
                    string answer = FindOtherRoots(remainder - square, i - 1);
                    if (answer != null)
                    {
                        return answer + " " + i;
                    }
                }
            }

            return null;
        }

    }
}
