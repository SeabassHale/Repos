using static System.Console;


namespace Debugging
{
    internal class Program
    {
        static void Main()
        {
            
            double a = 4.5;
            double b = 2.5;
            double answer = Add(a, b);
            WriteLine($"{a} + {b} = {answer}");

            WriteLine("Press ENTER to end the app.");
            ReadLine(); // wait for user to end the app
        }

        /// <summary>
        /// Returns the sum of two doubles
        /// </summary>
        /// <param name="a">Needs a double, yo</param>
        /// <param name="b">Needs another double, fool</param>
        /// <returns>The sum of your inputs baby!</returns>
        static double Add(double a, double b)
        {
            return a + b; // deliberate bug!
        }
    }
}