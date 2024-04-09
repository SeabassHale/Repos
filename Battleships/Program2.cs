using static System.Console;

namespace Battleships
{
    internal class Program
    {
        static void Main()
        {
            WriteLine("Welcome to Battleships.");

            BattleShipGameMenu();
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
            Write("Please choose a grid size 10/15/20: ");
            string input = ReadLine();
            int intInput;
            bool intCheck = int.TryParse(input, out intInput);
            while (intCheck == true)
            {
                switch (intInput)
                {
                    case 10:
                        BattleShipGameMain(intInput); break;
                    case 15:
                        BattleShipGameMain(intInput); break;
                    case 20:
                        BattleShipGameMain(intInput); break;
                    default:
                        WriteLine("Invalid input. Please enter 10, 15 or 20");
                        BattleShipNewGame();
                        break;
                }
            }
        }

        static void BattleShipGameMain(int _gridSize)
        {
            int gridSize = _gridSize;
            bool gameOver = false;
            List<GridPoint> Playboard = new List<GridPoint>();
            List<GridPoint> playerShipLocations = new List<GridPoint>();
            List<GridPoint> computerShipLocations = new List<GridPoint>();
            List<string> playerOneGuesses = new List<string>();
            List<string> computerGuesses = new List<string>();

            GridListBuilder(gridSize, Playboard);

            // get player to input playerOneShipLocations
            // *** TESTING TESTING TESTING ***
            playerShipLocations.Add(new GridPoint("A10", true));
            playerShipLocations.Add(new GridPoint("B10", true));
            playerShipLocations.Add(new GridPoint("C10", true));
            // *** END OF TESTING ***


            // populate computerShipLocations
            // *** TESTING TESTING TESTING ***
            computerShipLocations.Add(new GridPoint("A1", true));
            computerShipLocations.Add(new GridPoint("B1", true));
            computerShipLocations.Add(new GridPoint("C1", true));
            // *** END OF TESTING ***


            foreach (GridPoint BoardGridPoint in Playboard)
            {
                foreach (GridPoint compLocation in computerShipLocations) 
                {
                    if (BoardGridPoint.Location == compLocation.Location)
                    {
                        BoardGridPoint.ComputerShip = true;
                    }
                } 
            }

            foreach (GridPoint BoardGridPoint in Playboard)
            {
                foreach (GridPoint playerLocation in playerShipLocations)
                {
                    if (BoardGridPoint.Location == playerLocation.Location)
                    {
                        BoardGridPoint.ComputerShip = true;
                    }
                }
            }

            while (!gameOver)
            {
                bool validGuess = false;
                string coOrdGuess = " ";
                
                // Draw grid
                DrawGrid(gridSize, Playboard);

                // Player guess time
                while (!validGuess)
                {
                    WriteLine("Guess a co-ordinate e.g. B4: ");
                    coOrdGuess = ReadLine();

                    // error check player input
                    coOrdGuess = coOrdGuess.Trim().ToUpper();
                    if (coOrdGuess.Length == 2)
                    {
                        validGuess = true;
                    }
                }
                // compare input against computerShipLocations
                WriteLine("PotatoCheck2");
                
                // announce hit or miss
                // announce if ship has been sunk

                // redraw grid with updated missed/hit guesses
                DrawGrid(gridSize, Playboard);

                {
                    // Get computer to generate a random guess
                    // or
                    // if last guess was successful guess an adjacent location
                }

                // compare computer guess to playerShipLocations;
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

        static List<GridPoint> GridListBuilder(int gridSize, List<GridPoint> _gridlist)
        {
            int _gridSize = gridSize;
            List<GridPoint> GridList = _gridlist;
            List<string> xCoOrds = new()
            { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T"};

            for (int y = 0; y < _gridSize; y++)
            {
                for (int i = 0; i < _gridSize; i++)
                {
                    GridList.Add(new GridPoint($"{xCoOrds[i]}{Convert.ToString(_gridSize-y)}"));
                }
            }
            return GridList;
        }

        static void DrawGrid(int gridSize, List<GridPoint> _playboard)
        {
            int _gridSize = gridSize;
            List<GridPoint> Playboard = _playboard;
            List<string> xCoOrds = new()
            { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T"};


            Write("\n  ");
            for (int z = 0; z < _gridSize; z++)
            {
                Write($" _");
            }
            Write("\n");
            for (int y = 0; y < _gridSize; y++)
            {
                if ((_gridSize-y) < 10)
                {
                    Write($" {_gridSize-y}");
                }
                else
                {
                    Write($"{_gridSize-y}");
                }

                for (int i = 0; i < _gridSize; i++)
                {
                    // Need to add in a check against whether section has been guessed or not to mark as X and O for HIT.
                    Write($"|_");

                    // Adds each gridpoint (A1, A2, A3... to a list of gridpoints which make up the "Playboard". THIS NEEDS TO BE MOVED OUT OF THE GRID DRAWER AS YOU'RE DOUBLING UP THE DATA IN THE LIST EACH TIME YOU DRAW THE GRID
                    //Playboard.Add(new GridPoint($"{xCoOrds[i]}{Convert.ToString(_gridSize-y)}"));
                }
                WriteLine($"|");

            }
            Write("  ");
            for (int z = 0; z < _gridSize; z++)
            {
                Write($" {xCoOrds[z]}");
            }
            Write("\n");

            //return Playboard;
        }

        static void OpponentShipPlacement()
        {
            WriteLine("NOTE: COMPUTER TO PLACE SHIPS ON BOARD NOW");
        }
    }
}