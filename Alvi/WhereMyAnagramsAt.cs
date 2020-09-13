using System.Collections.Generic;

namespace CodewarsTest.Alvi
{
    class WhereMyAnagramsAt
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> anagramList = new List<string>();

            foreach (string variation in words)
            {
                List<char> tempWord = new List<char>(word.ToCharArray());
                bool notAnagram = false;

                foreach (char letter in variation)
                {
                    if (tempWord.Count == 0)
                    {
                        notAnagram = true;
                        break;
                    }
                    else if (tempWord.Contains(letter))
                    {
                        tempWord.Remove(letter);
                    }
                    else
                    {
                        notAnagram = true;
                        break;
                    }
                }

                if (notAnagram == true)
                {
                    continue;
                }

                else if (tempWord.Count == 0)
                {
                    anagramList.Add(variation);
                }
            }

            return anagramList; 
        }

    }
}
