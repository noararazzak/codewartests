using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class GeneticAlgorithm_3
    {
        public IEnumerable<string> Crossover(string chromosome1, string chromosome2, int cut)
        {
            List<string> chromosomesList1 = new List<string>(chromosome1.ToCharArray().Select(x => x.ToString()));
            List<string> chromosomesList2 = new List<string>(chromosome2.ToCharArray().Select(x => x.ToString()));
            List<string> chromosomesList3 = new List<string>(chromosome1.ToCharArray().Select(x => x.ToString()));
            for (int i = cut; i < chromosomesList1.Count; i++)
            {
                chromosomesList1[i] = chromosomesList2[i];
            }

            for (int i = cut; i < chromosomesList2.Count; i++)
            {
                chromosomesList2[i] = chromosomesList3[i];
            }

            string answer1 = string.Concat(chromosomesList1);
            string answer2 = string.Concat(chromosomesList2);

            IEnumerable<string> finalAnswer = new string[] { answer1, answer2 };
            return finalAnswer;
        }
    }
}
