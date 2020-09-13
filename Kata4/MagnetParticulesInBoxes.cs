using System;


namespace CodewarsTest
{
    class MagnetParticulesInBoxes
    {
        public static double Doubles(int maxk, int maxn)
        {
            
            double sum = 0;

            for (int i = 1; i < maxn + 1; i++)
            {
                for (int j = 1; j < maxk + 1; j++)
                {
                    sum = sum + (1 / (double)(j * Math.Pow(1 + i, 2*j)));
                }

                
            }

            return sum;
        }
    }
}
