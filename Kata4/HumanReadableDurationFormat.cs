using System;
using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class HumanReadableDurationFormat
    {
        public static string FormatDuration(int n)
        {
            int i = 0;

            List<int> time = new List<int>() { 31536000, 86400, 3600, 60 };
            List<int> values = new List<int>() { 0, 0, 0, 0 };
            List<string> names = new List<string> { "year", "day", "hour", "minute", "second" };
            List<string> finalnames = new List<string> { null, null, null, null, null };
            List<string> result = new List<string>();
            string finalresult = null;

            if (n == 0)
            {
                finalresult = "now";
            }
            while (n > 59)
            {
                values[i] = n / time[i];

                if (values[i] < 1)
                {
                    i = i + 1;
                }

                else if (values[i] >= 1)
                {
                    n = n % time[i];
                    i = i + 1;
                }
            }

            values.Add(n);

            for (int j = 0; j < values.Count; j++)
            {
                if (values[j] == 1)
                {
                    finalnames[j] = values[j] + " " + names[j];
                }

                else if (values[j] > 1)
                {
                    finalnames[j] = values[j] + " " + names[j] + "s";
                }

                else
                {
                    finalnames[j] = null;

                }
            }

            for (int j = 0; j < finalnames.Count; j++)
            {
                if (finalnames[j] != null)
                {
                    result.Add(finalnames[j]);
                }

            }

            for (int j = 0; j < result.Count; j++)
            {
                if (j == result.Count - 2)
                {
                    finalresult = finalresult + result[j] + " and ";
                }

                else if (j == result.Count - 1)
                {
                    finalresult = finalresult + result[j];
                }

                else
                {
                    finalresult = finalresult + result[j] + ", ";
                }


            }

            return finalresult;
        }
    }
}
