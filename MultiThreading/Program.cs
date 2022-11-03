using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Program
    {
        
        [Obsolete] //it is used because we are using Suspend() and Resume() Methods
        static void Main(string[] args)
        {
            
            Console.WriteLine("Main Thread is the starting point ");

            Threading.Print(); //callling  Print method from threading class

            Thread t1 = new Thread(Threading.Method1) //Method1 is passed into thread object
            {
                Name = ""
            };

            

            Thread t2 = new Thread(Threading.Method2)
            {
                Name = ""
            };


            Thread t3 = new Thread(Threading.Method3)
            {
                Name = ""
            };

        

            Thread t4 = new Thread(Threading.Method4)
            {
                Name = ""
            };

            t1.Start(); //thread t1 is started/executed


            t2.Start(); //thread t2 is ended/ terminated

            t2.Join(); //makes thread t2 wait for t1 to finish 
                        //NOTE: we can see output the "Method2-{0} is printed first"
            
            t3.Start(); //thread t3 is started/executed

            t3.Suspend(); //execution of Thread t3 is paused temporarily

            t3.Resume(); //resumes the execution of suspended thread

            t4.Abort(); //thread t4 is terminated

           

            Console.ReadLine();
        }
        
    }
        
    }

