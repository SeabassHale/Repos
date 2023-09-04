using static System.Console;

namespace Exercise_3._1___TYK
{
    internal class Program
    {
        static void Main()
        {
            // 1. What happens when you divid an int variable by 0?
            // int a = 1;
            // a /= 0;
            // Unhandled exception thrown

            // 2. What happens when you divide a double variable by 0?
            // double b = -2;
            // b /= 0;
            // WriteLine(b);
            // Everything is converted to 8/-8 as double has a definition of infinity, while int does not.

            // 3. What happens when you overflow an int variable?
            // int c = int.MaxValue;
            // c++;
            // Console.WriteLine(c);
            // It rolls around to the opposite end of the number line/spectrum

            // 4. What is the difference between x = y++; and x = ++y;
            // int x;
            // int y = 1;
            // x = y++;
            // x = ++y;
            // WriteLine(x);
            // ++y is completed before assignment, while y++ is completed after assignment.

            // 5. What is the difference between break, continue and return when used inside a loop statement?

            // 8.

            //checked
            //{
            //    int max = 500;
            //    for (byte i = 0; i < max; i++)
            //    {
            //        WriteLine(i);
            //    }
            //}

            int a = 1;
            while (a <= 100) 
            {
                if ( a % 5 == 0 && a % 3 == 0)
                {
                    Write(" FizzBuzz ");
                }

                else if (a % 5 == 0)
                {
                    Write(" Buzz ");
                }
                
                else if ( a % 3 == 0)
                {
                    Write(" Fizz ");
                }

                else
                {
                    Write($" {a} ");
                }
                a++;
            }
        }
    }
}