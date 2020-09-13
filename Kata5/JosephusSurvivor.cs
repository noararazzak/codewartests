using System;
using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class JosephusSurvivor
    {
        public static int JosSurvivor(int n, int k)
        {
            int number = 0;
            int remainingSurvivor = 0;
            while (number < n)
            {
                number = number + 1;

                if (n == 1)
                {
                    return 1;
                }

                else if (n > 1)
                {
                    remainingSurvivor = (JosSurvivor((n - 1), k) + (k - 1)) % n + 1;
                }

                if (number <= n)
                {
                    break;
                }
            }

            return remainingSurvivor;
        }
    }
}
