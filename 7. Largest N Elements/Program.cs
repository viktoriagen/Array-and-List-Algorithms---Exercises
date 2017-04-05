using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var totalNumbers = int.Parse(Console.ReadLine());

            var result = new List<int>();

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < totalNumbers; i++)
            {
                result.Add(numbers[i]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
