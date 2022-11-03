
// Priority property of Thread class
using System;
using System.Threading;

class Priority
    {
    
        // Main Method
        static public void Main()
        {

            // Creating and initializing threads
            Thread T1 = new Thread(work1);
            Thread T2 = new Thread(work2);

            // Set the priority of threads
            // Here T2 thread executes first
            // because the Priority of T2 is
            // highest as compare to T1 thread
            T1.Priority = ThreadPriority.Lowest;
            T2.Priority = ThreadPriority.Highest;
            T1.Start();
            T2.Start();
        }
        public static void work1()
        {

            Console.WriteLine("T1 thread is working..");
        }
        public static void work2()
        {

            Console.WriteLine("T2 thread is working..");
            Console.ReadLine();
        }
    
       
    }



