using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            //hold uniqie words
            var foundWords = new List<string>();
            //holds word occurences
            var wordCount = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                if (foundWords.Contains(currentWord))
                {
                    int wordIndex = foundWords.IndexOf(currentWord);
                    wordCount[wordIndex]++;
                }
                else
                {
                    foundWords.Add(currentWord);
                    wordCount.Add(1);
                }
            }
            //bubble  sort
            bool hasSwapped = true;
            while (hasSwapped)
            {
                hasSwapped = false;
                for (int i = 0; i < wordCount.Count - 1; i++)
                {
                    if (wordCount[i] < wordCount[i + 1])
                    {
                        int temp = wordCount[i];
                        wordCount[i] = wordCount[i + 1];
                        wordCount[i + 1] = temp;

                        string tempWord = foundWords[i];
                        foundWords[i] = foundWords[i + 1];
                        foundWords[i + 1] = tempWord;

                        hasSwapped = true;
                    }
                }
            }
            // selection Sort
            //for (int i = 0; i < wordCount.Count; i++)
            //{
            //    for (int j = 0; j < wordCount.Count; j++)
            //    {
            //        if (wordCount[i] > wordCount[j])
            //        {
            //            int temp = wordCount[i];
            //            wordCount[i] = wordCount[j];
            //            wordCount[j] = temp;

            //            var tempWord = foundWords[i];
            //            foundWords[i] = foundWords[j];
            //            foundWords[j] = tempWord;
            //        }
            //    }
            //}

            for (int i = 0; i < foundWords.Count; i++)
            {
                double currentPercentage = ((double)wordCount[i] * 100) / (double)words.Length;
                Console.WriteLine("{0} -> {1} times ({2:f2}%)", foundWords[i], wordCount[i], currentPercentage);
            }
        }
    }
}
