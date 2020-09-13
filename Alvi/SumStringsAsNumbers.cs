using System.Numerics;

namespace CodewarsTest.Alvi
{
    class SumStringsAsNumbers
    {
        public static string sumStrings(string a, string b)
        {
            BigInteger aInt = 0;
            BigInteger bInt = 0;

            BigInteger.TryParse(a, out aInt);
            BigInteger.TryParse(b, out bInt);

            return (aInt + bInt).ToString();
        }
    }

}

