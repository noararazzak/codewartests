using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsTest.Alvi
{
    class StringsMix
    {
        public static string Mix(string s1, string s2)
        {
            List<StringComp> availableChars = new List<StringComp>();

            List<char> s1List = s1.ToList();
            List<char> s2List = s2.ToList();

            var s1Groups = s1List.Where(c => char.IsLower(c)).OrderBy(c => c).GroupBy(c => c).Where(g => g.Count() > 1);
            var s2Groups = s2List.Where(c => char.IsLower(c)).OrderBy(c => c).GroupBy(c => c).Where(g => g.Count() > 1);

            foreach (var group in s1Groups)
            {
                availableChars.Add(new StringComp(1, group.Key, group.Count()));
            }
            foreach (var group in s2Groups)
            {
                StringComp prevStringSameChar = availableChars.Where(m => m.Letter == group.Key).FirstOrDefault();

                if (prevStringSameChar != null)
                {
                    if (group.Count() > prevStringSameChar.Count)
                    {
                        prevStringSameChar.Count = group.Count();
                        prevStringSameChar.BelongsTo = 2;
                    }

                    else if (group.Count() == prevStringSameChar.Count) { prevStringSameChar.BelongsTo = 3; }
                }
                else
                {
                    availableChars.Add(new StringComp(2, group.Key, group.Count()));
                }
            }

            availableChars = availableChars.OrderBy(m => m.Letter).OrderBy(m => m.BelongsTo).OrderByDescending(m => m.Count).ToList();

            return BuildResultString(availableChars);

        }

        private static string BuildResultString(List<StringComp> compList)
        {
            string result = string.Empty;

            for (int id = 0; id < compList.Count; id++)
            {
                if (compList[id].BelongsTo != 3) { result += compList[id].BelongsTo + ":"; }
                else { result += "=:"; }
                for (int i = 0; i < compList[id].Count; i++) { result += "" + compList[id].Letter; }
                if (id != compList.Count - 1) { result += "/"; }
            }

            return result;
        }

        private class StringComp
        {
            public int BelongsTo { get; set; }
            public char Letter { get; set; }
            public int Count { get; set; }

            public StringComp(int belongsTo, char letter, int count)
            {
                BelongsTo = belongsTo;
                Letter = letter;
                Count = count;
            }
        }
    }
}




