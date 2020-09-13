using System;
using System.Collections.Generic;
using System.Linq; 

namespace CodewarsTest
{
    public class ExpressionsMatter
    {
        public int FindHighestNumber(int a, int b, int c)
        {
            int Option1 = a * (b + c);
            int Option2 = a * b * c;
            int Option3 = a + (b * c);
            int Option4 = (a + b) * c;
            int Option5 = a + b + c;
            int Option6 = (a * b) + c;

            List<int> Options = new List<int>() { Option1, Option2, Option3, Option4, Option5, Option6 };
            int maximum = Options.Max(); 

            return maximum; 

            

         }

    }
}

