using System;
using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class Combinatorics
    {
        public List<string> FindCombinations(string input)
        {
            var charInput = input.ToLower().ToArray().Where(c => c >= 'a' && c <= 'z');

            var q = input.Select(x => x.ToString());
            int size = q.Count();
            for (int i = 0; i < size - 1; i++)
                q = q.SelectMany(x => input, (x, y) => x + y).Distinct();

            List<string> combinations = new List<string>();
            foreach (var item in q)
            {
                var charOutput = item.ToLower().ToArray().Where(c => c >= 'a' && c <= 'z');
                if (charInput.OrderBy(c => c).SequenceEqual(charOutput.OrderBy(c => c)))
                {
                    combinations.Add(item);
                }
            }


            return combinations;
        }
        
		
    }
}
