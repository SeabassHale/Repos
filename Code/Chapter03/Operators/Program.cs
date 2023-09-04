using static System.Console;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // P96
            int a = 3;
            int b = a++; //a is incremented after assignment using a postfix operator. The operator is increasing the value of a
            WriteLine($"a is {a}, b is {b}");
            int c = 3;
            int d = ++c; //c is incremented before assignment using a prefix operator 
            WriteLine($"c is {c}, d is {d}");

            //P97
            int e = 11;
            int f = 3;
            WriteLine($"e is {e}, f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");
            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f = {g / f}");
        }
    }
}