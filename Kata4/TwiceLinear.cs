using System;
using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class TwiceLinear
    {
        public static int Linear(int n)
        {
            int a = 0; 
            List<int> numbers = new List<int>();
            numbers.Add(1);
            while (a < n * 5)
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
        }

       

    }
}




