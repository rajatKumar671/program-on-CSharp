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
           
            Console.WriteLine("Enter the Number of Rows and Columns : ");
           int a = Convert.ToInt32(Console.ReadLine());
           int b= Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[a, b];
            Console.WriteLine("Enter the First Matrix");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("First matrix is:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] arr1= new int[a, b];
            Console.WriteLine("Enter the Second Matrix");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Second Matrix is :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix Multiplication is :");
            int[,] mul= new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                        mul[i, j] += arr[i, j] * arr1[i, j];
                    }
                }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(mul[i, j] + "\t");
                }
                Console.WriteLine();

            }

        }
    }
}



