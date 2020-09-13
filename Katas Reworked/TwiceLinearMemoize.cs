using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTest
{
    static class TwiceLinearMemoize
    {
        public static Func<A, R> Memoize<A, R>(this Func<A, R> f)
        {
            var map = new Dictionary<A, R>();
            return a =>
            {
                R value;
                if (map.TryGetValue(a, out value))
                    return value;
                value = f(a);
                map.Add(a, value);
                return value;
            };
        }

        public static Func<int, int> LinearAgain = n =>
        {
            int a = 0;
            List<int> numbers = new List<int>();
            numbers.Add(1);
            while (a < 5*n)
            {
                int x = (2 * numbers[a] + 1);
                int y = (3 * numbers[a] + 1);

                a = a + 1;

                numbers.Add(x);
                numbers.Add(y);
            }

            numbers.Sort();
            numbers = numbers.Distinct().ToList();
            return numbers[n];
        };
        
    }
}

  

  