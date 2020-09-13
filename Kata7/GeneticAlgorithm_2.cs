using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class GeneticAlgorithm_2
    {
        public string Mutate(string chromosome, double probability)
        {

            List<string> chromosomesList = new List<string>(chromosome.ToCharArray().Select(x => x.ToString()));

            int cutNumber = (int)(chromosome.Length * probability);

            for (int i = 0; i < cutNumber; i++)
            {
                if (chromosome[i] == '1')
                {
                    chromosomesList[i] = "0";

                }

                else if (chromosome[i] == '0')
                {
                    chromosomesList[i] = "1";

                }

            }

            string answer = string.Concat(chromosomesList);

            return answer;
        }
    }
}
