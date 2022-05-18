using System;
using System.Collections.Generic;
using System.Text;

namespace Kontejner.Models
{
	public class Container:Base

	{
		public Guid ContainerID { get; protected set; }
		public Container(int weight, int height, int length, int width) : base(weight, height, length, width)
		{
			ContainerID = new Guid();
		}
		public void ContainerSpaceLeft()
		{
			Console.WriteLine($"{Container.Volume} amount of space is left");
		}

		public void AddBox(Box box)
		{
			Container.Volume -= Box.Volume;
		}

		public void RemoveBox(Box box)
		{
			Container.Volume += Box.Volume;
		}

		public bool SizeCheck(Box box)
		{
			if (Box.Volume > Container.Volume)
				return true;
			return false;
		}
	}
}
