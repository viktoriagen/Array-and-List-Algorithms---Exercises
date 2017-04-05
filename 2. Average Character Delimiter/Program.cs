using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var sum = 0;
            var count = 0;
            for (int i = 0; i < input.Count; i++)
            {
                var symbol = input[i];
                for (int j = 0; j < symbol.Length; j++)
                {
                    sum += symbol[j];
                    count++;
                }
            }

            var average = sum / count;
            if (average >= 97 && average <= 122)
            {
                average -= 32;
            }
            char asciiSymbol = (char)average;

            Console.WriteLine(string.Join($"{asciiSymbol}", input));
        }
    }
}
