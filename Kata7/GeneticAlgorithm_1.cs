using System;
using System.Collections.Generic;


namespace CodewarsTest
{
    class GeneticAlgorithm_1
    {
        public string Generate(int length)
        {
            List<string> randomStrings = new List<string>();
            int number = 0;
            int i = 1;
            Random r = new Random();

            while (i <= length)
            {
                i = i + 1;
                number = r.Next(0, 2);
                randomStrings.Add(number.ToString());

            }

            string answer = string.Join<string>("", randomStrings);

            return answer;
        }
    }
}
