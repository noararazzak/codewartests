using System;
using System.Collections.Generic;
using System.Linq;

class WhatIsThisWord_v0
{
    private IEnumerable<string> words;

    public WhatIsThisWord_v0(IEnumerable<string> words)
    {
        this.words = words;
    }

    public string FindMostSimilar(string term)
    {
        List<WordFitness> wordfitness = new List<WordFitness>();
        double termfitness = 0;
        double i = 0;

        foreach (string word in words)
        {
            i = 0;
            //if (term.Length <= word.Length)
            //{
            //    foreach (char c in word)
            //    {
            //        if (!term.Contains(c.ToString()))
            //        {
            //            i = i + 1;
            //        }

            //    }
            //}

            //else
            //{
            //    foreach (char c in term)
            //    {
            //        if (!word.Contains(c.ToString()))
            //        {
            //            i = i + 1;
            //        }

            //    }
            //}
            string commonsum = "";
            
            var common = word.Intersect(term);
            bool foundword = term.Intersect(common).SequenceEqual(common); 
            foreach (char c in common)
            {
                i = i + 1;
                commonsum = commonsum + c;
                
            }
            Console.WriteLine(commonsum);
            Console.WriteLine(foundword); 
            
            if (term.Length > word.Length)
            {
                termfitness =  i/ term.Length; 
            }
            else if (word.Length >= term.Length)
            {
                termfitness = i/word.Length;
            }
            Console.WriteLine(i); 
            wordfitness.Add(new WordFitness { fitness = termfitness, givenword = word });
            common = null; 
        }

        List<WordFitness> orderedwordfitness = wordfitness.OrderByDescending(x => x.fitness).ToList();
        for (int j = 0; j < wordfitness.Count; j++)
        {
            Console.WriteLine("Fitness: " + orderedwordfitness[j].fitness + "," + "Given Word: " + orderedwordfitness[j].givenword);
        }
        return orderedwordfitness[0].givenword;
    }

    
}


class WordFitness
{
    public double fitness;
    public string givenword;
}
