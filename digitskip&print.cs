using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the digits");
            string str = Console.ReadLine();
            int[] number = new int[(str.Length)];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(str.Substring(i, 1));
            }

            int len = number.Length-1;
            for (int i = 0; i <= number.Length - 1; i++)
            {
                int a = number[i];
                int no = len - i;

                if (no > number[i])
                {
                   
                    Console.WriteLine(number[(i+1)+ a]);
                }

                else
                {
                    Console.WriteLine("After skip {0} no digit available", number[i]);

                }
            }
            Console.WriteLine();
        }

    }
}

