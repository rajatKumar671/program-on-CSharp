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
           
            Console.WriteLine("Enter the String Value ");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            int len = ch.Length - 1;

              for(int i=0;i<=ch.Length/2;i++)
            {
                char temp = ch[i];
                ch[i] = ch[len];
                ch[len] = temp;
                len--;
            }
            Console.WriteLine(ch);
          
        }
    }
}



