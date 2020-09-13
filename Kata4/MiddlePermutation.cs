using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class MiddlePermutation
    {
        public static string MiddlePermGenerator(string s)
        {
            List<string> sList = new List<string>();
            sList.AddRange(s.Select(c => c.ToString())); 
            sList.Sort();
            string finalresult = null;
            decimal factorialTotal = 1;
            decimal middlePerm = 0; 
            int n = sList.Count;
            int i = 1;

            while ( i < n + 1)
            {
                factorialTotal = factorialTotal * (decimal)i;
                i = i + 1; 
            }

            middlePerm = factorialTotal / 2;
            finalresult = GenerateSequence(middlePerm, n, sList, string.Empty);
            return finalresult + sList[0]; 
        }

        public static string GenerateSequence(decimal remainder, int number, List<string> list, string answer)
        {
            int i = 1;
            int j = 0;
            decimal factorial = 1;
            while (i < number)
            {
                factorial = factorial * (decimal)i;
                i = i + 1; 
            }
            if (remainder % factorial != 0)
            {
                j = (int)(remainder / factorial);
            }
            else
            {
                j = (int)(remainder / factorial) -1;
               
            }
          
            answer += list[j];
            list.Remove(list[j]);
            remainder = remainder - j * factorial;
            
            while (list.Count > 1)
            {
                answer = GenerateSequence(remainder, number-1 , list, answer);
            }

            return answer; 
           
        }
    }
}
