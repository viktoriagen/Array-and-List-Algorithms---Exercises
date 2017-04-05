using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var turns = Console.ReadLine().Split(' ').ToArray();
            bool death = false;
            var resultIndex = 0;

            for (int i = 0; i < turns.Length; i++)
            {
                var currentTurn = turns[i].Split(',').ToArray();
                var strengt = int.Parse(currentTurn[0]) + resultIndex;
                var direction = currentTurn[1];

                if (direction == "Right")
                
                {
                    if (strengt  > cylinder.Length - 1)
                    {
                         resultIndex += (strengt  % cylinder.Length);
                    }
                    else
                    {
                         resultIndex = strengt;
                    }
                   
                }
                else if (direction == "Left")
                {
                    if (strengt > cylinder.Length)
                    {
                         resultIndex = cylinder.Length - (strengt % cylinder.Length);
                    }
                    else
                    {
                         resultIndex = cylinder.Length - strengt;
                    }
                }
                if (cylinder[resultIndex] == 1)
                {
                    death = true;
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    break;
                }

            }
            if (!death)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
