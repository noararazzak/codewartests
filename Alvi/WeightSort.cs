using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace CodewarsTest.Alvi
{
    class WeightSort
    {
        public static string orderWeight(string strng)
        {
            string result = string.Empty;

            List<string> numStringList = LongStringToStringList(strng);

            List<WeightValuePair> valuePairs = new List<WeightValuePair>();

            foreach (string numString in numStringList)
            {
                valuePairs.Add(new WeightValuePair(numString));
            }

            valuePairs = valuePairs.OrderBy(s => s.StringNumber).ToList();
            valuePairs = valuePairs.OrderBy(w => w.Weight).ToList();


            for (int id = 0; id < valuePairs.Count; id++)
            {
                if (id == valuePairs.Count-1) { result += valuePairs[id].StringNumber; }
                else { result += valuePairs[id].StringNumber + " "; }
 
            }

            return result;
        }

        private static List<string> LongStringToStringList(string numbersAsString)
        {
            List<string> result = new List<string>();

            Regex regxSearch = new Regex(@"\d+");
            Match regxMatch = regxSearch.Match(numbersAsString);

            while (regxMatch.Success)
            {
                result.Add(regxMatch.Value);
                regxMatch = regxMatch.NextMatch();
            }
       
            return result;
        }

    }

    class WeightValuePair
    {
        private string _stringNumber;

        public string StringNumber
        {
            get { return _stringNumber; }
            set
            {
                _stringNumber = value;
                Weight = StringNumberToWeight(value);
            }
        }

        public int Weight { get; private set; }

        public WeightValuePair(string stringNumber)
        {
            StringNumber = stringNumber;
        }

        private int StringNumberToWeight(string numString)
        {
            int numberWeight = 0;

            foreach (char num in numString)
            {
                if (int.TryParse(num.ToString(), out int charIntValue)) { numberWeight += charIntValue; }
            }
            return numberWeight;
        }

    }
}



