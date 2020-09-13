using System.Collections.Generic;


namespace CodewarsTest
{
    public class NextSmallerInteger
    {
        public static long NextSmaller(long number)
        {
            List<long> initialList = new List<long>();
            List<long> sortedList = new List<long>();
            List<long> finalList = new List<long>();
            int cut = 0;
            int nextsmallest = 0; 
            long total = 0; 
            while (number > 0)
            {
                initialList.Add(number % 10);
                number = number / 10;
            }

            if (initialList.Count == 1)
            {
                return -1;
            }


            for (int i = 0; i < initialList.Count; i++)
            {
                if (initialList[i + 1] > initialList[i])
                {
                    cut = i + 1;
                    break;
                }

                if (i+1 == initialList.Count - 1)
                {
                    return -1;
                  
                }
                
           
            }

            
            if (cut == initialList.Count - 1 && initialList[cut] == 1)
            {
               return -1; 
            }

            for (int i = 0; i < cut + 1; i++)
            {
                sortedList.Add(initialList[i]); 
            }

            sortedList.Sort();
            sortedList.Reverse();

            for (int i = 0; i < sortedList.Count; i++)
            {
                if (initialList[cut] > sortedList[i])
                {
                    nextsmallest = i;
                    break; 
                   
                }
            }

            for (int i = initialList.Count-1; i > cut; i--)
            {
                finalList.Add (initialList[i]); 
            }

            finalList.Add (sortedList[nextsmallest]);
            sortedList.RemoveAt(nextsmallest);

            for (int i = 0; i < cut; i++)
            {
                finalList.Add (sortedList[i]); 
            }

            if (finalList[0] == 0)
            {
                return -1;
            }


            foreach (long entry in finalList)
            {
                total = 10 * total + entry; 
            }

            return total;

            
        }
    }
}
 