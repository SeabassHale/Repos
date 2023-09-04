using System;

namespace Test
{
    internal class Program
    {
        static void Main()
        {

            int invid = 0;
            string input = Console.ReadLine();
            invid = Convert.ToInt32(input);
            string[] test1 = { "poo", "turd", "chokky", "dump" };
            string[] test2 = { "banana", "apple", "orange", "grape" };
            test1[0] = "poo";
            test2[0] = "banana";

            Console.WriteLine($"{test1[invid]} - {test2[invid]}");
            Main();
        }
    }
}
