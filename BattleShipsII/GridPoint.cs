using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipsII
{
    internal class GridPoint
    {
        public string Identifier { get; set; }
        public bool PlayerShip = false;
        public bool ComputerShip = false;
        public bool PlayerGuess = false;
        public bool ComputerGuess = false;
        public GridPoint(string identifier)
        {
            Identifier = identifier;
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
