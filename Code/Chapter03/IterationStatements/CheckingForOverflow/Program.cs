using static System.Console;

namespace CheckingForOverflow
{
    internal class Program
    {
        static void Main()
        {
            int x = int.MaxValue - 1;
            int y = 0;

            try
            {
                checked
                {
                    do
                    {
                        WriteLine(x);
                        x++;
                        y++;
                    }
                    while (y < 3);
                }
            }

            catch (OverflowException)
            {
                WriteLine("The code overflowed but the \"checked\" and \"try\" and \"catch\" functions caught it");
            }

            unchecked
            {
                int z = int.MaxValue + 1;
            }
        }
    }
}