using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class BreadCrumbGenerator
{
    public static string GenerateBC(string url, string separator)
    {
        List<string> elementList = GetMatchingTexts(url, @"[^\/\s]+");

        for (int i = 0; i < elementList.Count; i++)
        {
            List<string> tempMatches = GetMatchingTexts(elementList[i], @"^[^.#\?\s]+");

            if (tempMatches.Count == 0)
                elementList.RemoveAt(i);
            else
                elementList[i] = tempMatches[0];
        }
        elementList = elementList.Where(e => e.ToLower() != "http:" && e.ToLower() != "https:" && e.ToLower() != "index").ToList();
        elementList[0] = "home";

        List<string> labelList = elementList.Select(e => e.ToUpper()).Select(e => e.Replace('-',' ')).ToList();

        string result = string.Empty;

        for (int i = 0; i < labelList.Count; i++)
        {
            if (labelList[i].Length > 30)
            {
                labelList[i] = Acronymize(labelList[i]);
            }

            string elementStart = "<a href=";
            string elementEnd = "</a>";
            string prevDir = "\"";
            string dirName = "/" + elementList[i] + "/\">";
            string currentSeparator = separator;

            if (i == 0 && labelList.Count > 1)
                dirName = "/\">";

            else if (i == labelList.Count - 1)
            {
                elementStart = "<span class=";
                elementEnd = "</span>";
                prevDir = "";
                dirName = "\"active\">";
                currentSeparator = "";
            }

            else if (i != 0 && i >= 2)
                prevDir = "\"/" + elementList[i - 1];

            result += elementStart + prevDir + dirName + labelList[i] + elementEnd + currentSeparator;
        }

        return result;
    }

    private static List<string> GetMatchingTexts(string text, string searchTerm)
    {
        List<string> result = new List<string>();

        Match regxMatch = new Regex(searchTerm).Match(text);

        while (regxMatch.Success)
        {
            result.Add(regxMatch.Value);
            regxMatch = regxMatch.NextMatch();
        }

        return result;
    }

    private static string Acronymize(string label)
    {
        string newlabel = string.Empty;
        List<string> garbageList = new List<string> { "the", "of", "in", "from", "by", "with", "and", "or", "for", "to", "at", "a" };

        List<string> words = label.Split(' ').ToList();
        foreach (string garbage in garbageList) {words = words.Where(w => w.ToLower() != garbage).ToList();}

        for (int w = 0; w < words.Count; w++)
        {
            newlabel += words[w][0];
        }
        return newlabel;
    }
   
}
