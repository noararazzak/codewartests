using System;
using System.Collections.Generic;
using System.Linq;


namespace CodewarsTest
{
    class ObservedPIN
    {
        public List<string> PIN(string a)
        {
            List<string> input = a.Select(x => x.ToString()).ToList();
            int size = input.Count();

            List<List<int>> lstMaster = new List<List<int>>(); 

            for (int i = 0; i < size; i++)
            {
                if (input[i] == "1")
                {
                    lstMaster.Add(new List<int> { 1, 2, 4 }); 
                }

                else if (input[i] == "2")
                {
                    lstMaster.Add(new List<int> { 1, 2, 3, 5 });
                }

                else if (input[i] == "3")
                {
                    lstMaster.Add(new List<int> { 2, 3, 6 });
                }

                else if (input[i] == "4")
                {
                    lstMaster.Add(new List<int> { 1, 4, 5, 7});
                }

                else if (input[i] == "5")
                {
                    lstMaster.Add(new List<int> { 2, 4, 5, 6, 8});
                }

                else if (input[i] == "6")
                {
                    lstMaster.Add(new List<int> { 3, 6 , 5 ,9});
                }

                else if (input[i] == "7")
                {
                    lstMaster.Add(new List<int> { 4, 7, 8 });
                }

                else if (input[i] == "8")
                {
                    lstMaster.Add(new List<int> { 5, 7, 8 ,9 ,0 });
                }

                else if (input[i] == "9")
                {
                    lstMaster.Add(new List<int> { 6, 9, 8 });
                }

                else if (input[i] == "0")
                {
                    lstMaster.Add(new List<int> { 0, 8 });
                }

            }


            IEnumerable<string> lstResult = new List<string> { null };
            foreach (var list in lstMaster)
            {
                lstResult = lstResult.SelectMany(x => list.Select(s => x + s)); 
            }


            List<string> finalResult = lstResult.ToList();


            return finalResult; 
                

        }

    }
}
