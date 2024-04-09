namespace BattleShipsII
{
    internal class Program
    {
        static void Main()
        {
            GameBoard gameBoard = new GameBoard(100);

            GameBoard.GameBoardBuilder(gameBoard);

            for( int i = 0; i < 100; i++) 
            {
                Console.WriteLine(gameBoard.PlayBoard[i]);
            }
        }
    }
}
