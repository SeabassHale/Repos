using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace BattleShipsII
{
    public class GameBoard
    {


        public int GameBoardSize { get; set; }
        public GridPoint[] GridPoints { get; set; }
        
        public GameBoard(int gameBoardSize, GridPoint[] _gridPoints)
        {
            GameBoardSize = gameBoardSize;
            GridPoints = _gridPoints;
        }
        

        public static GameBoard GameBoardBuilder(GameBoard _gameboard)
        {
            GameBoard gb = _gameboard;
            return gb;
        }


        public static void DrawGameBoard()
        {
            int GridSize = 10;
            List<string> xCoOrds = new()
            { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T"};


            Write("\n  ");
            for (int i = 0; i < GridSize; i++)
            {
                Write($" _");
            }
            Write("\n");
            for (int i = 0; i < GridSize; i++)
            {
                if ((GridSize-i) < 10)
                {
                    Write($" {GridSize-i}");
                }
                else
                {
                    Write($"{GridSize-i}");
                }

                for (int j = 0; j < GridSize; j++)
                {
                    Write($"|_");
                }
                WriteLine($"|");

            }
            Write("  ");
            for (int i = 0; i < GridSize; i++)
            {
                Write($" {xCoOrds[i]}");
            }
            Write("\n");
        }

        //public static void DrawGameBoard(GameBoard board)
        //{
        //    int GridSize = 10;
        //    List<string> xCoOrds = new()
        //    { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T"};


        //    Write("\n  ");
        //    for (int i = 0; i < GridSize; i++)
        //    {
        //        Write($" _");
        //    }
        //    Write("\n");
        //    for (int i = 0; i < GridSize; i++)
        //    {
        //        if ((GridSize-i) < 10)
        //        {
        //            Write($" {GridSize-i}");
        //        }
        //        else
        //        {
        //            Write($"{GridSize-i}");
        //        }

        //        for (int j = 0; j < GridSize; j++)
        //        {
        //            Write($"|_");
        //        }
        //        WriteLine($"|");

        //    }
        //    Write("  ");
        //    for (int i = 0; i < GridSize; i++)
        //    {
        //        Write($" {xCoOrds[i]}");
        //    }
        //    Write("\n");
        //}

    }
}
