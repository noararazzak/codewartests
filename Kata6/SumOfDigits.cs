using System;
using System.Collections.Generic;


namespace CodewarsTest
{
    class SumOfDigits
    {
        public int DigitalRoot(long n)
        {
            int summation = 0;
            string numberString = n.ToString();
            List<char> numberList = new List<char>();
            numberList.AddRange(numberString);

            for (int i = 0; i < numberList.Count; i++)
            {
                int number = Int32.Parse(numberList[i].ToString());
                summation = summation + number;
            }

            while (summation > 9)
            {
                int summationOther = 0;
                string summationString = summation.ToString();
                List<char> summationList = new List<char>();
                summationList.AddRange(summationString);

                for (int i = 0; i < summationList.Count; i++)
                {
                    int number = Int32.Parse(summationList[i].ToString());

                    summationOther = summationOther + number;
                    summation = summationOther;
                }
            }

            return summation;
        }
    }
}
