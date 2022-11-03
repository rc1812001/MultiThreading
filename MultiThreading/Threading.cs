using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Threading
    {
        public static void Print() //print to print a statement
        {
            Console.WriteLine("We are going to learn about Threading ");
        }
        public static void Method1()
        {
            for (int i = 0; i < 5; i++) //to print 0-4 numbers
            {
                Console.WriteLine("Method1 - {0}" , i);
            }
        }

        public static void Method2()
        {
            for(int i = 0; i < 5; i++) //to print 0-4 numbers
            {
                Console.WriteLine("Method2 - {0}",i);
                Thread.Sleep(2000);
            }

        }

        public static void Method3()
        {
            for (int i = 0; i <5; i++) //to print 0-4 numbers
            {
                Console.WriteLine("Method3 - {0}" , i);
                Thread.Sleep(3000); //It will halt method 2 for 4 seconds
            }
           
        }

        public static void Method4() //to print 0-4 numbers
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method4 - {0}", i);
               
            }

        }
    }
}
