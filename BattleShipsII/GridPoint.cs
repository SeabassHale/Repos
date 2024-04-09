using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsII
{
    public class GridPoint
    {
        public string Identifier = "";
        public bool PlayerShip = false;
        public bool ComputerShip = false;
        public bool PlayerGuess = false;
        public bool ComputerGuess = false;
        public GridPoint()
        {
            Identifier = "";
            PlayerShip = false;
            ComputerShip = false;
            PlayerGuess = false;
            ComputerGuess = false;
        }

        public static string GridPointIdentifierBuilder(string _x, string _y)
        {
            string Identifier = ($"{_x}{_y}");
            return Identifier;
        }


    }
}
