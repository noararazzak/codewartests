using System.Collections.Generic;
using System.Linq;

namespace CodewarsTest.Alvi
{
    public class UniqueOrder
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> result = new List<T>();

            foreach (var letter in iterable)
            {
                if (result.Count == 0 || !result.Last().Equals(letter))
                {
                    result.Add(letter);
                }
            }
            return result;
        }
 
    }
}
