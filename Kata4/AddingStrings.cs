using System;
using System.Numerics; 

namespace CodewarsTest
{
    class AddingStrings
    {
        public string AddStuff(string a, string b)
        {
            BigInteger aInt = 0;
            BigInteger bInt = 0;

            if (a != "")
            {
                aInt = BigInteger.Parse(a);
            }
            if (b != "")
            {
                bInt = BigInteger.Parse(b);
            }

            BigInteger addition = aInt + bInt;

            string answer = addition.ToString(); 

            return answer; 

        }
    }
}
