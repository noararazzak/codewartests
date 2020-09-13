using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTest
{
    public class StringEndsWith
    {
        public bool MatchWords(string a, string b)
        {
            string[] array1 = a.Select(x => new string(x, 1)).ToArray();
            string[] array2 = b.Select(x => new string(x, 1)).ToArray();

            bool continueiteration = true;
            Array.Reverse(array1);
            Array.Reverse(array2);
            if (array1.Length <= array2.Length)
            {
                continueiteration = false;
            }
                
            if (continueiteration == true)
            {
                for (int i = 0; i < array2.Length; i = i + 1)
                {

                    if (array2[i] == array1[i])
                    {
                        continueiteration = true;
                    }

                    else
                    {
                        continueiteration = false;
                    }

                } 

            }

            return continueiteration; 

        }
        
    }
}
