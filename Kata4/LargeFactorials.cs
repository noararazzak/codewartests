using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsTest
{
    class LargeFactorials
    {
        public static string Factorial(int n)
        {
            int number = 1;
            List<int> factorial = new List<int>() {1};

            while (number <= n)
            {
                factorial = Multiply(number, factorial);
                number++;
            }

            factorial.Reverse();
            return string.Join("", factorial.ToArray());
        }

        public static List<int> Multiply(int number, List<int> factorial)
        {
            int quotient = 0;

            for (int i = 0; i < factorial.Count; i++)
            {
                int multiplication = factorial[i] * number + quotient;
                int modulo = multiplication % 10;
                quotient = multiplication / 10;

                factorial[i] = modulo;
                if (i == factorial.Count - 1 && quotient > 0)
                {
                    factorial.Add(0);
                }

            }

            return factorial;
        }
    }
}
