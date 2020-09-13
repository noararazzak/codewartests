using System;
using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class Scramblies
    {
        public static bool Scramble(string string1, string string2)
        {
            char[] charArray1 = string1.ToCharArray();
            char[] charArray2 = string2.ToCharArray();

            List<char> charList3 = new List<char>();



            var charList1 = new List<char>(charArray1);
            var charList2 = new List<char>(charArray2);
            foreach (char c in charList2)
            {
                if (c == charList1.Find(x => x == c))
                {
                    charList1.Remove(c);
                    charList3.Add(c);
                }
            }

            char[] charArray3 = charList3.ToArray();
            Array.Sort(charArray2);
            Array.Sort(charArray3);

            if (charArray3.SequenceEqual(charArray2))
            {
                return true;
            }

            else
            {
                return false;
            }


        }

    }
}
