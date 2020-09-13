using System;
using System.Collections.Generic;
using System.Linq;

using CodewarsTest;

class TheObservedPIN
{
    public static List<string> GetPINs(string observed)
    {
        List<string> result = new List<string>();

        List<char> charList = observed.ToList().Where(c => c >= '0' && c <= '9').ToList();
        int possibleCount = 0;

        foreach (char num in charList) { possibleCount += Utility.Factorial(GetNeighbors(Int32.Parse(num.ToString())).Count() + 1); }

        for (int i = 0; i < possibleCount; i++)
        {
            foreach (char num in charList)
            {

            }
        }

        Utility.WriteListinLine(charList,"");
        Console.WriteLine();
        Console.WriteLine(possibleCount);

        return new List<string>();
    }

    private static List<int> GetNeighbors(int num)
    {
        switch (num)
        {
            case 0: return new List<int> { 8 };
            case 1: return new List<int> { 2, 4 };
            case 2: return new List<int> { 1, 3, 5 };
            case 3: return new List<int> { 2, 6 };
            case 4: return new List<int> { 1, 5 };
            case 5: return new List<int> { 2, 4, 6, 8 };
            case 6: return new List<int> { 3, 5, 9 };
            case 7: return new List<int> { 4, 8 };
            case 8: return new List<int> { 0, 5, 7, 9 };
            case 9: return new List<int> { 6, 8 };
            default: return null;
        }

    }
}
