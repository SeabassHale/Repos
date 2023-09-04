namespace Potato
{
    class Program
    {
        static void Main()
        { 

            string secretWord = "osterich";
            string guess = "";
            int guessCount = 0;

            Console.WriteLine("Guess the secret word. You have up to 3 guesses");

            while (guess != secretWord && guessCount <= 2)
            {
                Console.WriteLine($"You have had {guessCount} guesses.");
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guessCount++;
            }
            if (guess == secretWord)
                Console.WriteLine("You win!");
            else
                Console.WriteLine("You lose.");
        }

        /*
        {
           
            int index = -3;
            do
            {
                Console.WriteLine(index);
                Console.WriteLine(Object1(index));
                index++;
            } while (index >= -1 && index <= 5);
        }   
        static string Object1(int ObjInt)
        {
            string ObStri1;

            switch (ObjInt)
            {
                case 1:
                    ObStri1 = "One";
                    break;
                case 2:
                    ObStri1 = "Two";
                    break;
                case 3:
                    ObStri1 = "Three";
                    break;
                case 4:
                    ObStri1 = "Four";
                    break;
                case 5:
                    ObStri1 = "Five";
                    break;
                default:
                    ObStri1 = "Bonus Mystery";
                    break;
            }

            return ObStri1;
        }
        */
                
    }
}
