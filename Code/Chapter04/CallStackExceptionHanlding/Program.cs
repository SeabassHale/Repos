using CallStackExceptionHandlingLib;
using static System.Console;

namespace CallStackExceptionHanlding
{
    internal class Program
    {
        static void Main()
        {
            WriteLine("In Main");
            Alpha();
            

        }

        static void Alpha()
        {
            WriteLine("In Alpha");
            Beta();
        }

        static void Beta()
        {
            WriteLine("In Beta");
            try
            {
                Calculator.Gamma();
            }
            catch(Exception ex)
            {
                WriteLine($"Caught this: {ex.Message}");
                throw ex; // removing "ex" re-throws the full stack error message.
            }
        }
    }
}