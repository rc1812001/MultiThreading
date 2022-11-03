
// use of IsAlive property
using System;
using System.Threading;

public class CheckThreadStatus
    {

        // Main Method
        static public void Main()
        {
            Thread thr;

            // Get the reference of main Thread
            // Using CurrentThread property
            thr = Thread.CurrentThread;

            // Display the current state of
            // the main thread Using IsAlive
            // property
            Console.WriteLine("Is main thread is alive" +
                                " ? : {0}", thr.IsAlive);
             // Display the current state
             // of the main thread
             Console.WriteLine("The name of the current state of the Main "
                          + "thread is: {0}", thr.ThreadState);

        Console.ReadLine();
        }
    }


