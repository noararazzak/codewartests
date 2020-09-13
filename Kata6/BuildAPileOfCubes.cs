using System;


namespace CodewarsTest
{
    class BuildAPileOfCubes
    {
        public static long FindNumbers(long m)
        {
            long n = 0;
            long summation = 0;


            while (summation <= m)
            {
                n = n + 1;
                summation = summation + (long)Math.Pow(n, 3);
                if (summation == m)
                    break;
            }



            if (summation != m)
            {
                return -1;
            }

            return n;
        }
    }
}
