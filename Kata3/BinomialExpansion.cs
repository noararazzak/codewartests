using System;
using System.Collections.Generic;
using System.Text.RegularExpressions; 


namespace CodewarsTest.Katas.Kata3
{
    class BinomialExpansion
    {

        public static long powerRule(long a, long power)
        {
            long answer = 1;
            for (long i = 0; i < power; i++)
            {
                answer = a * answer;
            }

            return answer;
        }

        public static string powerString(string a, long b)
        {
            if (b == 0)
            {
                return "";
            }
            else if (b == 1)
            {
                return a;
            }
            else
            {
                return (a + "^" + b.ToString());
            }

        }

        public static long factorial(long n)
        {
            long answer = 1;
            for (long i = 0; i < n; i++)
            {
                answer = answer * (n - i);
            }

            return answer;

        }

        public static long combinatorics(long n, long k)
        {

            long answern = factorial(n);
            long answerk = factorial(k);
            long answer_nk = factorial(n - k);

            long answer = answern / ((answerk) * (answer_nk));

            return answer;
        }

        public static List<int> stringParserNumber(string str)
        {
            List<int> numberList = new List<int>();
            char[] strArray = str.ToCharArray();

            if (!Char.IsDigit(strArray[1]) && Char.IsLetter(strArray[1]))
            {
                numberList.Add(1);
            }
            else if (!Char.IsDigit(strArray[1]) && Char.IsLetter(strArray[2]))
            {
                numberList.Add(-1);
            }
            MatchCollection matches = Regex.Matches(str, @"-?\d+");
            foreach (Match s in matches)
            {
                int k = int.Parse(s.Value);
                numberList.Add(k);

            }
            return numberList;
        }
        public static string stringParserLetter(string str)
        {
            string letter;
            var match = Regex.Match(str, @"[a-zA-Z]+");
            letter = match.ToString();
            return letter;
        }

        public static string Expand(string expr)
        {
            List<int> numListFinal = new List<int>();
            numListFinal = stringParserNumber(expr);
            long a = numListFinal[0];
            long b = numListFinal[1];
            long n = numListFinal[2];
            string c = stringParserLetter(expr);
            List<string> resultList = new List<string>();
            string finalResult = "";
            if (b == 0)
            {
                if (a == 1)
                {
                    return c + "^" + n.ToString();
                }
                long intFront = powerRule(a, n);
                return intFront.ToString() + c + "^" + n.ToString();
            }
            if (n == 0)
            {
                return "1";
            }
            for (int i = 0; i < n + 1; i++)
            {
                long combFinal = combinatorics(n, n - i);
                string strFinal = powerString(c, n - i);
                long intFront = powerRule(a, n - i);
                long intBack = powerRule(b, i);
                long multiple = combFinal * intFront * intBack;
                if (i == 0 && multiple == 1)
                {
                    finalResult += strFinal;
                }
                else if (i == 0 && multiple == -1)
                {
                    finalResult += "-" + strFinal;
                }
                else if (i > 0 && multiple == 1)
                {
                    finalResult += "+" + strFinal + multiple.ToString();
                }
                else if (i > 0 && multiple > 1)
                {
                    finalResult += "+" + multiple.ToString() + strFinal;
                }
                else
                {
                    finalResult += multiple.ToString() + strFinal;
                }

                //Console.WriteLine("multiple:" + multiple + "combFinal:" + combFinal + "intFront:" + intFront + "intBack:" + intBack);
            }

            return finalResult;
        }

        public static void Main()
        {
            int a = -5;
            int b = 3;
            int c = 6;
            long answerPower;
            long answerFactorial;
            long answerCombinatorics;
            string answerPowerStr;
            string stringTest;
            List<int> numListTest = new List<int>();
            string resultTest;

            answerPower = powerRule(a, b);
            answerFactorial = factorial(15);
            answerCombinatorics = combinatorics(15, 14);
            answerPowerStr = powerString("b", b);
            numListTest = stringParserNumber("(-x-4)^0");
            stringTest = stringParserLetter("(-x-4)^0");
            resultTest = Expand("(-8t+11)^9");
            Console.WriteLine(answerPower);
            Console.WriteLine(answerFactorial);
            Console.WriteLine(answerCombinatorics);
            Console.WriteLine(answerPowerStr);
            foreach (int i in numListTest)
            {
                Console.WriteLine(i); 
            }
            Console.WriteLine(stringTest);
            Console.WriteLine(resultTest);
        }
    }

}
        
