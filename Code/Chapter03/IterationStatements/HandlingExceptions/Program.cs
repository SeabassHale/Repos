using static System.Console;

namespace HandlingExceptions
{
    internal class Program
    {
        static void Main()
        {
            // HANDLING EXCEPTIONS: WRAPPING ERROR PRONE CODE IN A TRY BLOCK

            WriteLine("Before parsing");
            Write("What is your age? ");
            string? input = ReadLine();

            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch (FormatException)
            {
                WriteLine("The age you entered is not a valid number format");
            }
            catch (OverflowException)
            {
                WriteLine("That's too big (or too small) a number");
            }
            
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After parsing");


            Write("Enter an amount: ");
            string? amount = ReadLine();

            try
            {
                decimal amountValue = decimal.Parse(amount);
            }
            catch (FormatException) when (amount.Contains("$") || amount.Contains("£"))
            {
                WriteLine("Amounts cannot use the $ or £ sign!");
            }
            catch (FormatException)
            {
                WriteLine("Amounts must only contain digits!");
            }
        }
    }
}