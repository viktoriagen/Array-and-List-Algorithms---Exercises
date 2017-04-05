using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Insertion_Sort_Using_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
           
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
