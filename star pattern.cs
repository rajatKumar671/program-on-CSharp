using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program

    {

        public static void Main()
        {

            Console.WriteLine("Enter the Value ");
            int num = int.Parse(Console.ReadLine());


            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <num; j++)
                    if (j >= i && j <= num - 1 - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                Console.WriteLine();
            }
                

            }
        }
    }


