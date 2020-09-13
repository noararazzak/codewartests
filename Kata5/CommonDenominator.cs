using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTest
{
    class CommonDenominator
    {
        public static string convertFrac(long[,] list)
        {
            List<long> denominators = new List<long>();
            List<long> nominators = new List<long>();
            List<long> newnominators = new List<long>();
            List<string> answers = new List<string>();

            string finalAnswer = null;

            if (list.Length == 0)
            {
                return string.Empty;
            }
            for (int i = 0; i < list.Length * 0.5; i++)
            {
                denominators.Add(list[i, 1]);


            }
            for (int i = 0; i < list.Length * 0.5; i++)
            {
                nominators.Add(list[i, 0]);

            }

            long[] denominatorsArray = denominators.ToArray();
            long commonDenominator = denominatorsArray.Aggregate(lcm);

            for (int i = 0; i < denominators.Count; i++)
            {
                newnominators.Add((commonDenominator * nominators[i]) / denominators[i]);

            }
            for (int i = 0; i < newnominators.Count; i++)
            {
                answers.Add("(" + newnominators[i].ToString() + "," + commonDenominator + ")");

            }



            finalAnswer = string.Join("", answers);

            return finalAnswer;
        }

        private static long lcm(long a, long b)
        {
            long num1 = 0;
            long num2 = 0;

            if (a > b)
            {
                num1 = a;
                num2 = b;
            }

            else
            {
                num1 = b;
                num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                if ((i * num1) % num2 == 0)
                {
                    return i * num1;
                }

            }

            return num1 * num2;
        }
    }
}
