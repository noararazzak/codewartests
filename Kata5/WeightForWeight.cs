using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace CodewarsTest
{
    class WeightForWeight
    {
        public static string OrderWeight(string s)
        {
            int total = 0;

            string result = null; 

            List<DifferentWeights> weightrecalibrated = new List<DifferentWeights>(); 

            Regex regex = new Regex(@"\d+");

            List<string> weights = new List<string>(); 
            
            foreach (Match match in regex.Matches(s))
            {

                weights.Add(match.Value); 
            }

           
            for (int i = 0; i < weights.Count; i++)
            {
                total = 0;
                foreach (char c in weights[i])
                {
                    total = total + Int32.Parse(c.ToString());

                }

                weightrecalibrated.Add(new DifferentWeights { number = weights[i], value = total });
            }

            var orderedweights= weightrecalibrated.OrderBy(x => x.value).ThenBy( y => y.number).ToList();

            for (int i = 0; i < orderedweights.Count; i++)
            {
                result = result + " " + orderedweights[i].number;
            }
            

            return result.Trim(); 
        }
        
    }

    public class DifferentWeights
    {
        public string number;
        public int value;
    }
}


