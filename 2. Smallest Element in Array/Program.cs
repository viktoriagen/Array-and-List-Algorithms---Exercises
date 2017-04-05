using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var minNumb = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumb)
                {
                    minNumb = numbers[i];
                }
            }
            Console.WriteLine(minNumb);
        }
    }
}
