using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodewarsTest.Alvi
{
    class TextAlignJustify
    {
        public static string Justify(string str, int len)
        {
            if (str == null || str == string.Empty) { return string.Empty; }

            List<string> wordList = GetWordList(str);

            if (wordList.Count <= 1) { return wordList[0] + "\n"; }

            List<List<string>> lines = GetLineList(len, wordList);
            return JustifyLineList(len, lines);

        }

        private static string JustifyLineList(int len, List<List<string>> lines)
        {
            string result = string.Empty;

            for (int l = 0; l < lines.Count; l++)
            {
                List<string> line = lines[l];
                int currentLength = line.Select(x => x.Length).Sum();
                int spacesToFill = len - currentLength;

                int spaceBeforeEachWord = 0;
                int extraSpaceUntil = 0;

                if (line.Count > 1)
                {
                    spaceBeforeEachWord = (int)(spacesToFill / (line.Count - 1));
                    extraSpaceUntil = spacesToFill % (line.Count - 1);
                }

                for (int w = 0; w < line.Count; w++)
                {
                    if (l == lines.Count - 1) { result += line[w]; }

                    else
                    {
                        if (w != 0)
                        {
                            for (int s = 0; s < spaceBeforeEachWord; s++) { result += " "; }
                        }
                        if (w > 0 && w <= extraSpaceUntil) { result += " "; }

                        result += line[w];
                    }
                }

                if (l != lines.Count - 1) { result += "\n"; }
            }

            return result;
        }

        private static List<List<string>> GetLineList(int length, List<string> wordList)
        {
            List<List<string>> lines = new List<List<string>>();

            int remainingSpaces = 0;
            int currentLine = -1;

            for (int w = 0; w < wordList.Count; w++)
            {
                string word = wordList[w];

                if (word.Length + 1 <= remainingSpaces)
                {
                    lines[currentLine].Add(" " + word);
                    remainingSpaces -= (word.Length + 1);
                }
                else
                {
                    lines.Add(new List<string>());
                    currentLine += 1;
                    lines[currentLine].Add(word);
                    remainingSpaces = length - word.Length;
                }
            }

            return lines;
        }

        private static List<string> GetWordList(string text)
        {
            List<string> result = new List<string>();

            Match regxMatch = new Regex(@"[^\s]+").Match(text);

            while (regxMatch.Success)
            {
                result.Add(regxMatch.Value);
                regxMatch = regxMatch.NextMatch();
            }

            return result;
        }
    }
}
