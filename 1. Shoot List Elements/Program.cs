using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            double average = 0;
            double sum = 0;
            double count = 0;
            var end = false;
            var lastShoot = int.MinValue;
            var list = new List<int>();
            var command = Console.ReadLine();
            while (command != "stop")
            {
                if (command != "bang")
                {
                    var num = int.Parse(command);
                    list.Insert(0, num);
                    count++;
                    sum += num;
                    average =  sum / count; 
                }
                else
                {
                    if (count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastShoot}");
                        end = true;
                        break;
                    }
                    else if (count == 1)
                    {
                        lastShoot = list[0];
                        Console.WriteLine($"shot {lastShoot}");
                        count--;
                    }
                    else
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] < average)
                            {
                                lastShoot = list[i];
                                Console.WriteLine($"shot {lastShoot}");
                                
                                count -= 1;
                                sum = sum - list[i] - count;
                                average = sum / count;
                                list.RemoveAt(i);
                                for (int j = 0; j < list.Count; j++)
                                {
                                    list[j] -= 1;
                                }
                                break;


                            }
                        }
                    }
                  
                }
                command = Console.ReadLine();
            }
            if (count == 0 && !end)
            {
                Console.WriteLine($"you shot them all. last one was {lastShoot}");
            }
            else if (count > 0)
            {
                Console.WriteLine("survivors: " + string.Join(" ",list));
            }

        }
    }
}
