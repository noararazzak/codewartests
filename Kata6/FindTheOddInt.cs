using System;
using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class FindTheOddInt
    {
        public static int FindIt(int[] seq)
        {

            int result = 0;
            int number = 2;
            List<int> seqList = seq.ToList();
            foreach (int i in seqList)
            {
                int count = seqList.Where(x => x == i).Select(x => x).Count();

                if (count % number == 1)
                {
                    result = i;
                    break;
                }

                else if (count % number == 0)
                {
                    result = -1;
                }
            }

            return result;

        }
    }
}
