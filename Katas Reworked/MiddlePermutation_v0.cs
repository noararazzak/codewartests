using System;
using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class MiddlePermutation_v0
    {

        public static string MiddlePermute(string s)
        {
            List<string> result = new List<string>();
            
            char [] charstrings =  s.ToCharArray();
            int length = charstrings.Length;
            Permute(charstrings, 0, length, result);
            int finallength = result.Count;
            result = result.OrderBy(x => x).ToList(); 
            foreach (string value in result)
            {
                Console.WriteLine(value); 
            }
            Console.WriteLine(result.Count); 
            if (finallength % 2 == 0)
            {
                return result[(finallength / 2)-1];
            }
            else
            {
                return result[((finallength + 1) / 2) -1];
            }

            

        }

        public static void Permute(char[] chars, int k, int n, List<string> result)
        {
            if (k == n)
            {
                result.Add(string.Empty);
                foreach (char letter in chars)
                {
                    result[result.Count - 1] += letter;
                }
            }

            else
            {
                for (int i = k; i < n; i++)
                {
                    Swap(ref chars[k], ref chars[i]);
                    Permute(chars, k + 1, n, result);
                    Swap(ref chars[k], ref chars[i]);
                }

            }

        }

        public static void Swap(ref char a, ref char b)
        {
            char temp;

            temp = a;
            a = b;
            b = temp; 
        }
    }
}
