using static System.Console;

namespace Battleships
{
    internal class Program
    {
        static void Main()
        {
            WriteLine("Welcome to Battleships.");

            BattleShipGameMenu();
            BattleShipNewGame();
        }

        static void BattleShipGameMenu()
        {
            WriteLine("Would you like to play a game? Y/N: ");
            string menuInput = ReadLine();
            YesNoInputCheck(menuInput);
            BattleShipNewGame();
        }

        static void BattleShipNewGame()
        {
            Write("Please choose a grid size (10 - 20): ");
            string input = ReadLine();
            int intInput;
            bool intCheck = int.TryParse(input, out intInput);
            while (true)
            {
                if (!intCheck || intInput < 10 || intInput > 20)
                {
                    WriteLine("Invalid input. Please enter a number between 10 - 20");
                    BattleShipNewGame();
                }
                OpponentShipPlacement();
                BattleShipGameMain(intInput);
            }
        }

        static void BattleShipGameMain(int _gridSize)
        {
            int gridSize = _gridSize;
            bool gameOver = false;

            List<string> playerOneGuesses = new List<string>();
            //List<TBC> playerOneShipLocations = new List<TBC>();
            
            // get player to input playerOneShipLocations

            List<string> computerGuesses = new List<string>();
            //List<TBC> computerShipLocations = new List<TBC>();

            // populate computerShipLocations 

            while (!gameOver)
            {
                bool validGuess = false;
                string coOrdGuess = " ";
                // Draw grid
                DrawGrid(gridSize);
                while (!validGuess)
                {
                    WriteLine("Guess a co-ordinate e.g. B4: ");
                    coOrdGuess = ReadLine();
                    
                    // error check player input
                    coOrdGuess = coOrdGuess.Trim().ToUpper();
                    if (coOrdGuess.Length == 2 && coOrdGuess[0].Equals("A"))
                    {
                        WriteLine("EGGSEGGS HE SAID EGGS");
                        
                        //coOrdGuess.Contains(coOrdGuess[0];
                    }
                }
                // compare input against computerShipLocations
                // announce hit or miss
                // announce if ship has been sunk

                // redraw grid with updated missed/hit guesses
                DrawGrid(gridSize);

                {
                    // Get computer to generate a random guess
                    // or
                    // if last guess was successful guess an adjacent location
                }

                // compare computer guess to playerChipLocations;
                // announce hit or miss
                // announce if ship has been sunk

                ReadLine();
            }
            
            // print win or lose game over message
            WriteLine("This is a Game Over message!");
            
            //
            ReadLine();
            BattleShipReplay();
        }

        //static string GuessInput(string _coOrdGuess)
        //{
        //    string guessInput = _coOrdGuess;
        //    while guessInput

        //}

        //static string GuessInputAndErrorChecking(string _Guess, List<string> _xGuessList)
        //{
        //    string Guess = _Guess.Trim().ToUpper();
        //    List<string> GuessList = _xGuessList;
        //    return ("");
        //    // return returnGuess;
        //}

        static void BattleShipReplay()
        {

            Write("Would you like to play again (Y/N) ");
            string replayInput = ReadLine();
            YesNoInputCheck(replayInput);
            BattleShipNewGame();
        }

        static void YesNoInputCheck(string _input)
        {
            string input = _input;
            if (input.ToLower() == "y")
            {
                //BattleShipNewGame();
                return;
            }
            else if (input.ToLower() == "n")
            {
                WriteLine("Goodbye");
                Environment.Exit(0);
            }
            else
            {
                Write("Invalid input, please try again: ");
                YesNoInputCheck(ReadLine());
            }

        }

        static void DrawGrid(int gridSize)
        {
            int x = gridSize;
            List<string> xCoOrds = new()
            { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T"};
            // int rowCount = 1;

            Write("\n  ");
            for (int z = 0; z < x; z++)
            {
                Write($" _");
            }
            Write("\n");
            for (int y = 0; y < x; y++)
            {
                if ((x-y) < 10)
                {
                    Write($" {x-y}");
                }
                else
                {
                    Write($"{x-y}");
                }

                for (int i = 0; i < x; i++)
                {
                    // Need to add in a check against whether section has been guessed or not.
                    Write($"|_");
                }
                WriteLine($"|");

            }
            Write("  ");
            for (int z = 0; z < x; z++)
            {
                Write($" {xCoOrds[z]}");
            }
            Write("\n");
        }

        static void OpponentShipPlacement()
        {
            WriteLine("NOTE: COMPUTER TO PLACE SHIPS ON BOARD NOW");
        }
    }
}