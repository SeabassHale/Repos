using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    internal class Ship
    {
        public Ship(int lenth)
        {
            Length = lenth;
        }

        public int Length { get; set; }
        public string startCoOrd = "";
        public string endCoOrd = "";

        private static void ShipPlacement(int Length, GridPoint gridPoint)
        {
            //List<GridPoint> shipGridPoints = new List<GridPoint>();

            return;
        } 
    }
}
