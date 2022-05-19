using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleTables;

namespace Kontejner.Models
{
	public class Container:Base

    {
        private List<Box> ContainerBoxes { get; set; }
		public Container(int weight, int height, int length, int width) : base(weight, height, length, width)
		{
            ContainerBoxes = new List<Box>();
		}
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

        public void GetTable(ConsoleTable table)
        {
            table.AddRow($"{ContainerID}", $"{ContainerBoxes.Count}", $"{Weight}");
        }
	}
}
