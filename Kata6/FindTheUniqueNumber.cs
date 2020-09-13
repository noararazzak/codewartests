using System;
using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class FindTheUniqueNumber
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int countOne = 0;
            int countTwo = 0;
            int answer = 0;
            var result = numbers.Distinct().ToList();
            foreach (int value in numbers)
            {
                if (value == result[0])
                {
                    countOne = countOne + 1;
                }

                else if (value == result[1])
                {
                    countTwo = countTwo + 1;
                }
            }

            if (countOne < countTwo)
            {
                answer = result[0];
            }

            else
            {
                answer = result[1];
            }

            return answer;
        }
    }
}
