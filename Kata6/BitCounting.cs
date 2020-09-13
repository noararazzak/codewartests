using System;
using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class BitCounting
    {
        public static int CountBits(int n)
        {
            int count = 0;
            List<int> binarynumbers = new List<int>();
            while (n > 0)
            {
                binarynumbers.Add(n % 2);
                n = (n - (n % 2)) / 2;

                if (n == 0)
                {
                    break;
                }
            }

            for (int i = 0; i < binarynumbers.Count; i++)
            {
                Console.WriteLine(binarynumbers[i]);
            }

            count = binarynumbers.FindAll(x => x == 1).Count();

            return count;
        }
    }
}
