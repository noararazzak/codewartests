using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTest
{
    public class BuildTower
    {
        public static string[] TowerBuilder(int nFloors)
        {
            if (nFloors == 0)
            {
                return new string[0];
            }
           
            int number = 0;
            int spaces = 0;
            List<string> pyramid = new List<string>();
            string element = null;
            for (int i = 0; i < nFloors; i++)
            {
                number = 2 * i + 1;
                int padRight = (2 * nFloors) - 1;
                spaces = padRight - number;
                int padLeft = spaces / 2 + number;

                element = new string('*', number);
                pyramid.Add(element.PadLeft(padLeft));
                
            }
            return pyramid.ToArray();
        }

    }
}
