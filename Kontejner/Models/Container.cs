using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using ConsoleTables;

namespace Kontejner.Models
{
	public class Container:Base

    {
	    public List<Box> ContainerBoxes { get; set; }
		public Container(int weight, int height, int length, int width) : base(weight, height, length, width)
		{
            ContainerBoxes = new List<Box>();
            Location = null;
		}

		public Ship Location { get; set; }

		public string GetContainerSpace()
		{
            return $"{this.AvailableVolume} amount of space is left";
		}
        public List<Box> GetContent()
        {
            return ContainerBoxes.ToList();
        }
		public void AddBox(Box box)
		{
			this.ContainerBoxes.Add(box);
            this.AvailableVolume -= box.Volume;

		}

		public void RemoveBox(Box box)
		{
            this.AvailableVolume += box.Volume;
		}


        public bool SizeCheck(Box box)
        {
            return box.AvailableVolume > this.AvailableVolume;
        }

        public void GetTable(ConsoleTable table,Container container)
        {
            table.AddRow($"{container.Location.shipID}", $"{ContainerID}", $"{ContainerBoxes.Count}", $"{Weight}");
        }
	}
}
