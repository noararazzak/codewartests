using System;
using System.Collections.Generic;

namespace CodewarsTest
{
    class GeneticAlgorithm_5
    {
        public string Select(IEnumerable<string> population, IEnumerable<double> fitnesses)
        {
            List<string> populationList = new List<string>();
            List<double> fitnessList = new List<double>();
            foreach (string person in population)
            {
                populationList.Add(person);
            }

            foreach (double number in fitnesses)
            {
                fitnessList.Add(number);
            }

            double sum = 0;

            for (int i = 0; i < populationList.Count; i++)
            {
                sum = sum + fitnessList[i];

            }

            Random r = new Random();
            double zero = 0;
            double next = r.NextDouble();

            double randomNumber = zero + (next * (sum - zero));

            double partialSum = 0;
            int index = 0;

            for (int i = 0; i < populationList.Count; i++)
            {
                partialSum = partialSum + fitnessList[i];

                if (partialSum < randomNumber)
                {
                    index = i + 1;
                }
            }

            return populationList[index];
        }
    }
}
