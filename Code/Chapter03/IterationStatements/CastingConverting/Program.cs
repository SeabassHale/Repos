using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a; // ant int can be safely cast in to a double
            WriteLine(b);

            double c = 9.8;
            //int d = c; // compiler throws an error for this line.
            int d = (int)c;
            WriteLine(d); // d will lose the .8

            long e = 5_000_000_000; // long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            double g = 9.8;
            int h = ToInt32(g); // a method of System.Convert
            WriteLine($"g is {g} and h is {h}");

            //Rounding

            double[] doubles = new[]
            { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

            foreach (double n in doubles)
            {
                WriteLine($"ToInt32({n}) is {ToInt32(n)}");
            }
            // C# will round up on odds, down on evens. This is called "Bankers Rounding".

            // Using Math.Round to take control of the rounding rules. 
            foreach (double n in doubles)
            {
                WriteLine(format:
                    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                    arg0: n,
                    arg1: Math.Round(value: n, digits: 0,
                        mode: MidpointRounding.AwayFromZero));
            }

            //CONVERTING TYPES TO STRING

            int number = 12;
            WriteLine(number.ToString());

            bool boolean = true;
            WriteLine(boolean.ToString());
            
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());

            object me = new();
            WriteLine(me.ToString());

            //CONVERTING FROM A BINARY OBJECT TO A STRING

            //allocate array of 128 bytes
            byte[] binaryObject = new byte[128];

            //populate array with random bytes
            (new Random()).NextBytes(binaryObject);

            WriteLine("Binary Objext as bytes:");

            for(int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X} ");
            }
            WriteLine();

            // convert to Base64 string and output as text
            string encoded = ToBase64String(binaryObject);

            WriteLine($"BinaryObject as Base64: {encoded}");

            // PARSING FROM STRINGS TO NUMBERS AND DATES

            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");

            WriteLine($"I was born {age} years ago");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}");

            //ERRORS USING PARSING

            // int count = int.Parse("abc"); // Throws a System.FormatException error code because can't convert letters to an int.

            // AVOIDING EXCEPTIONS USING TRYPARSE METHOD

            Write("How many eggs are there? ");
            string? input = ReadLine();

            if (int.TryParse(input, out int count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not Parse the input.");
            }

            // HANDLING EXCEPTIONS: WRAPPING ERROR PRONE CODE IN A TRY BLOCK


        }
    }
}