namespace BattleShipsII
{
    internal class Program
    {
        static void Main()
        {
            //GridPoint testgridpoint = new gridpoint();
            //testgridpoint.identifier = "potato";
            //console.writeline($"{testgridpoint.identifier}");

            GridPoint[] gridPoints = new GridPoint[100];
            char X = 'A';
            int Y = 1;
            for (int i = 0; i < gridPoints.Length; i++)
            {
                gridPoints[i] = new GridPoint();
                gridPoints[i].Identifier = GridPoint.GridPointIdentifierBuilder(Convert.ToString(X), Convert.ToString(Y));
                Y++;
                if( i == 10 || (i+1)%10  == 0)
                {
                    X++;
                    Y = 0;
                }

            }
            
            GameBoard gameBoard = new GameBoard(100, gridPoints);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(gameBoard.GridPoints[i].Identifier);
            }

            GameBoard.GameBoardBuilder(gameBoard);

            for( int i = 0; i < 100; i++) 
            {
                Console.WriteLine(gameBoard.GridPoints[i]);
            }
        }
    }
}
