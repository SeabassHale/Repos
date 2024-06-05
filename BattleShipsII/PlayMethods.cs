using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsII
{
    internal class PlayMethods
    {
        public static GameBoard PlayerGuessChecker(GameBoard board, string guess)
        {
            foreach (GridPoint gridPoint in board.GridPoints)
            {
                if (gridPoint.Identifier == guess)
                {
                    gridPoint.PlayerGuess = true;

                    if (gridPoint.ComputerShip == true)
                    {
                        gridPoint.ComputerHitFlag = true;
                        Console.WriteLine($"{guess} was a HIT!");
                    }
                    else
                    {
                        Console.WriteLine($"{guess} was a miss. :(");
                    }
                }
            }
            return board;
        }

        public static GameBoard ComputerGuessChecker(GameBoard board, string guess)
        {
            foreach (GridPoint gridPoint in board.GridPoints)
            {
                if (gridPoint.Identifier == guess)
                {
                    gridPoint.ComputerGuess = true;

                    if (gridPoint.PlayerShip == true)
                    {
                        gridPoint.PlayerHitFlag = true;
                        Console.WriteLine("HIT!!!!");
                    }
                    
                }
            }
            return board;
        }

        public static GameBoard PlayerShipPlacement(GameBoard board, string coords)
        {
            foreach (GridPoint gridPoint in board.GridPoints)
            {
                if (gridPoint.Identifier == coords)
                {
                    if (gridPoint.PlayerShip != false)
                    {
                        Console.WriteLine("There's already a ship there. Try another coordinate");
                    }
                    else
                    {
                        gridPoint.PlayerShip = true;
                    }
                }

            }
            return board;
        }
    }
}
