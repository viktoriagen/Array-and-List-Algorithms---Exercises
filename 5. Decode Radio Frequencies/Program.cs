using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var doubles = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var stringArray = new List[doubles](doubles);
            var resultArrayCount = 0;

            for (int i = 0; i < doubles.Length; i++)
            {
                var currentNumber = doubles[i].Split('.').toArray();
                var currentArray = 
            }
        }
    }
}
