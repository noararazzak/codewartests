using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTest
{
    class GoodVersesEvil
    {
        public static string GoodVsEvil(string good, string evil)
        {
            string answer = null;

            string[] goodies = good.Split(' ');
            string[] badies = evil.Split(' ');

            int[] worthgood = new int[6] { 1, 2, 3, 3, 4, 10 };

            int[] worthbad = new int[7] { 1, 2, 2, 2, 3, 5, 10 };



            int totalGood = 0;
            int totalEvil = 0;

            for (int i = 0; i < goodies.Length; i++)
            {
                int goodNumber = Convert.ToInt32(goodies[i]);
                int totalgoodEach = worthgood[i] * goodNumber;
                totalGood = totalGood + totalgoodEach;
            }
            for (int i = 0; i < badies.Length; i++)
            {
                int badNumber = Convert.ToInt32(badies[i]);
                int totalbadEach = worthbad[i] * badNumber;
                totalEvil = totalEvil + totalbadEach;
            }

            if (totalGood < totalEvil)
            {
                answer = "Battle Result: Evil eradicates all trace of Good";
            }

            else if (totalGood > totalEvil)
            {
                answer = "Battle Result: Good triumphs over Evil";
            }

            else if (totalGood == totalEvil)
            {
                answer = "Battle Result: No victor on this battle field";
            }

            return answer;
        }
    }
}
