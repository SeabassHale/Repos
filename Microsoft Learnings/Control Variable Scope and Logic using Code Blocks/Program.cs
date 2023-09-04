using System;

namespace Control_Variable_Scope_and_Logic_using_Code_Blocks
{
    class Program
    {
        static void Main()
        {
            int total = 0;
            bool found = false;
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            foreach (int number in numbers)
            {
                total += number;
                if (number == 42)
                    found = true;
            }
            if (found)
                Console.WriteLine("Set contains 42");
            Console.WriteLine($"Total: {total}");
        }
        
    }
}
