using System;
using System.Collections.Generic;


namespace CodewarsTest
{
    class IsMyFriendCheating
    {
        public static List<long[]> removNb(long n)
        {
            List<long[]> result = new List<long[]>();

            for (long i = 0; i <= n; i++)
            {
                double jdouble = (n * (n + 1D) - 2D * i) / (2D * (i + 1D));

                if (jdouble % 1 == 0 && jdouble <= (double)n)
                {
                    result.Add(new long[] { i, (long)jdouble });
                }
            }

            return result;
        }
    }
}
