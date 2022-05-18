using System;
using System.Collections.Generic;
using System.Text;

namespace Kontejner.Models
{
	public class Container:Base

	{
		public Guid ContainerID { get; private set; }
		public Container(int weight, int height, int length, int width) : base(weight, height, length, width)
		{
			ContainerID = new Guid();
		}
		public void ContainerSpaceLeft()
		{
            Console.WriteLine($"{this.AvailableVolume} amount of space is left");
		}

		public void AddBox(Box box)
		{
			this.AvailableVolume -= box.Volume;
		}

		public void RemoveBox(Box box)
		{
            this.AvailableVolume += box.Volume;
		}

		public bool SizeCheck(Box box)
		{
			if (box.AvailableVolume > this.AvailableVolume)
				return true;
			return false;
		}
	}
}
