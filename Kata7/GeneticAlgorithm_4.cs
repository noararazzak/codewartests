using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTest
{
    class GeneticAlgorithm_4
    {
        public IEnumerable<ChromosomeWrap> MapPopulationFit(IEnumerable<string> population, Func<string, double> fitness)
        {

            List<ChromosomeWrap> wrapList = new List<ChromosomeWrap>();

            double fitnessNumber = 0;

            foreach (string dna in population)
            {
                fitnessNumber = fitness(dna);

                wrapList.Add(new ChromosomeWrap { Chromosome = dna, Fitness = fitnessNumber });
            }


            IEnumerable<ChromosomeWrap> wrapEnum = wrapList;

            return wrapEnum;
        }
    }
}
