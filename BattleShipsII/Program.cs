namespace BattleShipsII
{
    internal class Program
    {
        static void Main()
        {

            GridPoint[] gridPoints = new GridPoint[100];
            char X = 'A';
            int Y = 1;
            for (int i = 0; i < gridPoints.Length; i++)
            {
                gridPoints[i] = new GridPoint();
                gridPoints[i].Identifier = GridPoint.GridPointIdentifierBuilder(Convert.ToString(X), Convert.ToString(Y));
                Y++;
                if( (i+1)%10  == 0)
                {
                    X++;
                    Y = 1;
                }

            }
            
            GameBoard gameBoard = new GameBoard(100, gridPoints);

            GameBoard.GameBoardBuilder(gameBoard);

            string testGuess1 = "A1";
            string testGuess2 = "J4";

            PlayMethods.PlayerShipPlacement(gameBoard, testGuess2);

            PlayMethods.PlayerGuessChecker(gameBoard, testGuess1);

            PlayMethods.ComputerGuessChecker(gameBoard, testGuess2);

        }
    }
}
