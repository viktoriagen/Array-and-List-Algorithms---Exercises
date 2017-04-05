using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {
            var obstacles = Console.ReadLine().Split(' ').ToList();
            var energy = int.Parse(Console.ReadLine());
            var startIndex = 0;
            bool deadByExplosion = false;
            bool success = false;

            while (energy > 0)
            {
                var curretObstacle = obstacles[startIndex].Split('|').ToList();

                if (curretObstacle[0] == "Right")
                {
                    int addNumber = (curretObstacle[1].ToString()[0]) - '0';
                    startIndex += addNumber;
                    energy -= addNumber;
                    if (startIndex > obstacles.Count - 1)
                    {
                        startIndex = startIndex % obstacles.Count;
                    }
                }
                else if (curretObstacle[0] == "Left")
                {
                    int addNumber = (curretObstacle[1].ToString()[0]) - '0';
                    startIndex -= addNumber;
                    energy -= addNumber;
                    if (startIndex < 0)
                    {
                        if (Math.Abs(startIndex) > obstacles.Count - 1)
                        {
                            var reverceIndex = startIndex % obstacles.Count;
                            startIndex = reverceIndex - 1;
                        }
                        else
                        {
                            var reverceIndex = Math.Abs(startIndex);
                            startIndex = reverceIndex - 1;
                        }

                    }
                }
                else if (curretObstacle[0] == "Bomb")
                {
                    int addNumber = (curretObstacle[1].ToString()[0]) - '0';
                    energy -= addNumber;
                    if (energy < 0)
                    {
                        deadByExplosion = true;
                        break;
                    }
                    obstacles.RemoveAt(startIndex);
                    startIndex = 0;


                }
                else if (curretObstacle[0] == "RabbitHole")
                {
                    success = true;
                    break;
                }
                if (obstacles[obstacles.Count - 1] == "RabbitHole")
                {
                    obstacles.Add("Bomb|"+ energy);
                }
                else
                {
                    obstacles[obstacles.Count - 1] = $"Bomb|{energy}";
                }

            }
            if (deadByExplosion == true)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            else if (success == true)
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
            }
            else
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }

        }

    }
}
