using System;

namespace Iterate_through_a_code_block
{
    internal class Program
    {
        static void Main()
        {
            /*
            for (Initiator variable "initializer"; completion "condition"; "iterator")
            {
                "body"
            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7) break;
            }


            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = names.Length - 1; i >= 0; i--)
                if (names[i] == "David") names[i] = "Sammy";

            foreach (var name in names) Console.WriteLine(name);

            */

            for (int j = 1; j < 101; j++)
            {
                if (j % 3 == 0)
                {
                    if (j % 5 == 0)
                        Console.WriteLine($"{j} Fizz-Buzz");
                    else
                        Console.WriteLine($"{j} Fizz");
                }
                else if (j % 5 == 0)
                    Console.WriteLine($"{j} Buzz");
                else
                    Console.WriteLine(j);
            }
            
        }
    }
}
