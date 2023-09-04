using static System.Console;

namespace IterationStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            //string? password;
            //int y = 0;

            //do
            //{
            //    Write("Enter your password: ");
            //    password = ReadLine();
            //    y++;
            //}
            //while (password != "Pa$$w0rd" && y < 10);

            // This is on optional test to set a limit to the number of password attempts. It works, but I think there's a shorter way of doing it.
            //if (password != "Pa$$w0rd" && y >= 10)
            //{
            //    WriteLine("You failed to get the correct password after 10 attempts");
            //}
            //else
            //{
            //    WriteLine("Correct!");
            //}

            for (int z = 1; z <= 10; z++)
            {
                WriteLine(z);
            }

            string[] names = { "Adam", "Barry", "Charlie" };

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }

        }
    }

}