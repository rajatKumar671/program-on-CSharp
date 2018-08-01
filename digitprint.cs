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

                int start = 1;
                int len = number.Length;
            int len1 = number.Length;
                int end = 0;
                for (int i = 0; i <= number.Length - 1; i++)
                {
                    int a = number[i];

                if (len > number[i])
                 {
                    end = number[i] + i;
                    for (int j = start; j <= end; j++)
                    {
                        Console.Write(number[j]);
                    }
                 }

                else
                 {
                    int no = i+1;
                    end = (len1 - 1) - i;

                    for (int j = 1; j <= end; j++)
                    {
                        Console.Write(number[no]);

                        no++;

                    }
                 }

                    
                    len--;
                    start++;
                    Console.WriteLine();
                }

            }
        }
}
