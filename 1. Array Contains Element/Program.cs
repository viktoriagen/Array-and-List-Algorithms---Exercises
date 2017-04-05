using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numberToFind = int.Parse(Console.ReadLine());
            var result = "no";

            foreach (var item in numbers)
            {
                if (item == numberToFind)
                {
                    result = "yes";
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
