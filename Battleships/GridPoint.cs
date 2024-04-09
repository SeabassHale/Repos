using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal class GridPoint
    {

        public string Location;
        private bool playerOneShip = false;
        private bool playerTwoShip = false;
        public bool ComputerShip = false;
        private bool playerOneGuessed = false;
        private bool playerTwoGuessed = false;


        public GridPoint(string location)
        {
            Location = location;
        }

        public GridPoint(string location, bool computerShip)
        {
            Location = location;
            ComputerShip = computerShip;
        }

        //public GridPoint(string location, bool computerShip)
        //{
        //    Location = location;
        //}



    }
}
