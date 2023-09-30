using System;
using System.Timers; // I think this is actually unnecessary these days?
using System.Collections.Generic; // This is used for Example 3, but again think it may be unnecessary.

namespace Timer_Example_Console
{

    //// Examples 1 & 2

    internal class Program
    {

     //Example 1
     //A very simple timer example that updates on a single line within the console

        static void Main()
        {
            
            System.Timers.Timer newTimer = new System.Timers.Timer();
            newTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
            newTimer.Interval = 1000;
            newTimer.Start();
            while (Console.Read() != 'q')  // I think this is supposed to quit the timer
            {

            }
        }

        public static void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            List<System.DateTime> timers = new List<System.DateTime>();

            while (true)
            {
                timers.Add(DateTime.Now);
            }
            Console.Write(timers);
        }


    //    // Example 2
    //    // Another simple timer that writes a new line to console

    //    //private static System.Timers.Timer timer;
    //    //public static void Main()
    //    //{
    //    //    timer = new System.Timers.Timer();
    //    //    timer.Interval = 6000;
    //    //    timer.Elapsed += OnTimedEvent;
    //    //    timer.AutoReset = true;
    //    //    timer.Enabled = true;
    //    //    Console.WriteLine("Please enter any key to exit from the code anytime...");
    //    //    Console.ReadLine();
    //    //}

    //    //private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    //    //{
    //    //    Console.WriteLine($"Event : {e.SignalTime}");
    //    //}


    } 


    //static class DemoTimers  // Example 3
    //{
    //    static System.Timers.Timer time;
    //    static List<DateTime> output = new List<DateTime>();
    //    public static void Start()
    //    {
    //        var timer = new System.Timers.Timer(5000);
    //        timer.Elapsed += new ElapsedEventHandler(Elapsed_time);
    //        timer.Enabled = true;
    //        time = timer;
    //    }


    //    static void Elapsed_time(object sender, ElapsedEventArgs e)
    //    {
    //        output.Add(DateTime.Now);
    //    }

    //    public static void PrintTimes()
    //    {
    //        if (output.Count > 0)
    //        {
    //            Console.WriteLine("TIMERS : ");
    //            foreach (var time in output)
    //            {
    //                Console.WriteLine(time.ToShortTimeString() + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        DemoTimers.Start();
    //        while (true)
    //        {
    //            DemoTimers.PrintTimes();
    //            Console.WriteLine("WAITING TO PRINT");
    //            System.Threading.Thread.Sleep(2000);
    //        }
    //    }
    //}

}