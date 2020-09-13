using System;
using System.Collections.Generic;



namespace CodewarsTest
{
    class NumberOfTrailingZerosofN
    {
        public static int TrailingZeros(int n)
        {
            double zero = 0;
            double number = (double)n;
            double totalZeros = 0;

            for (double i = 1; i < 20; i++)
            {
                zero = (number - (number % Math.Pow(5, i))) / Math.Pow(5, i);

                totalZeros = totalZeros + zero;
            }

            return (int)totalZeros;

        }
    }
}
