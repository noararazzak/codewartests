using System;
using System.Linq;


namespace CodewarsTest
{
    class AreTheyTheSame
    {
        public static bool Compare(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return false;
            }
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = (int)Math.Pow(a[i], 2);
            }

            Array.Sort(b);
            Array.Sort(c);
            if (b.SequenceEqual(c))
            {
                return true;
            }

            return false;
        }
    }
}
