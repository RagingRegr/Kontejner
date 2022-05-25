using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ConsoleTables;

namespace Kontejner.Models
{
    public class Port
    {
        public static int ShipCount { get; set; }
        public int[] ShipDistance { get; set; }
        public List<Ship> Ships { get; set; }

        public Port(int shipcount)
        {
            ShipCount = shipcount;
            Ships = new List<Ship>();
            ShipDistance = RandomizeArray(100,200);
        }
        public void AddShip(Ship ship)
        {
            this.Ships.Add(ship);
        }

        public int[] RandomizeArray(int min,int max)
        {
            Random rand = new Random();
            return new[] { rand.Next(min,max) };
        }

        public int MoveTime(int start, int end)
        {
            int time = 0;
            for (int i = start; i < end; i++)
            {
                time += ShipDistance[i];
            }
            return time;
        }
        public int MoveContainer(int start, int container, int end)
        {
            Ships[end].AddContainer(Ships[start].ContainersInside[container]);
            Ships[start].ContainersInside.Remove(Ships[start].ContainersInside[container]);
            int time = MoveTime(start, end);
            return time;
        }

    }
}
