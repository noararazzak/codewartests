using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTest
{
    class LongestCommonSubsequence
    {
        public int[,] LCS(string s1, string s2)
        {
            int[,] c = new int[s1.Length + 1, s2.Length + 1];
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        c[i + 1, j + 1] = c[i, j] + 1;
                    }
                    else
                    {
                        c[i + 1, j + 1] = Math.Max(c[i + 1, j], c[i, j + 1]);
                    }
                }
            }

            return c;
        }

        public string BackTrack(int[,] c, string s1, string s2, int i, int j)
        {
            if (i == -1 || j == -1)
            {
                return "";
            }
            else if (s1[i] == s2[j])
            {
                return BackTrack(c, s1, s2, i - 1, j - 1) + s1[i];
            }
            else if (c[i + 1, j] > c[i, j + 1])
            {
                return BackTrack(c, s1, s2, i, j - 1);
            }
            else
            {
                return BackTrack(c, s1, s2, i - 1, j);
            }

        }


        public string CommonSubsequence(string a, string b)
        {
            var c = LCS(a, b);
            var answer = BackTrack(c, a, b, a.Length-1, b.Length-1);
            return answer;

        }

    }
}
