using System.Collections.Generic;

namespace CodewarsTest.Alvi
{
    class DoubleLinear
    {
        public static int DblLinear(int n)
        {
            List<int> series = new List<int>();
            series.Add(1);

            int x = 0; int y = 0;

            while (series.Count < n + 1)
            {
                int possibleX = 2 * series[x] + 1;
                int possibleY = 3 * series[y] + 1;

                if (possibleX <= possibleY)
                {
                    series.Add(possibleX);
                    x++;

                    if (possibleX == possibleY) { y++; }
                }

                else
                {
                    series.Add(possibleY);
                    y++;
                }
            }

            return series[n];
        }
    }
}
