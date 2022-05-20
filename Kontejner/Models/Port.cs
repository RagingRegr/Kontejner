using System;
using System.Collections.Generic;
using System.Text;

namespace Kontejner.Models
{
    internal class Port
    {
        public static int ShipCount { get; set; }
        public int[] ShipDistance { get; set; } = new int[ShipCount-1];
        private List<Ship> Ships { get; set; }

        public Port(int shipcount)
        {
            ShipCount = shipcount;
            Ships = new List<Ship>();
        }
        public void AddContainer(Ship ship)
        {
            this.Ships.Add(ship);
        }
    }
}
