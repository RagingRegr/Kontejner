using System;
using System.Dynamic;

namespace Kontejner.Models
{
	public abstract class Base
	{
		public int Weight { get; private set; }
		public int Height { get;  }
		public int Length { get;  }
		public int Width { get; }
		public double Volume { get; }
		public double AvailableVolume { get; protected set; }
		public Guid ContainerID { get; }

        public void AddWeight(int addedWeight)
        {
			Weight += addedWeight;
        }

		public Base(int weight, int height, int length, int width)
		{
			Weight=weight;
			Height=height;
			Length=length;
			Width=width;
			AvailableVolume=Volume=height*length*width;
            ContainerID = Guid.NewGuid();
		}
	}
}