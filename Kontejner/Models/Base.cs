using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Kontejner.Models
{
    public abstract class Base
	{
        public List<string> CustomIds = new List<string>();
        public int Weight { get; private set; }
		public int Height { get;  }
		public int Length { get;  }
		public int Width { get; }
		public double Volume { get; }
		public double AvailableVolume { get; protected set; }
		public string ContainerID { get; }

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
            ContainerID = GetId();
        }

        public string GetId()
        {
            string id;
            int one, two, three;
            do
            {
                one = Helpers.Helpers.Randomizer(1, 9);
                two = Helpers.Helpers.Randomizer(1, 9);
                three = Helpers.Helpers.Randomizer(1, 9);
                id = one + "-" + two + three;
            } while (CheckIfExists(id));
            CustomIds.Add(id);
            return id;
        }
        public bool CheckIfExists(string id)
        {
            return CustomIds.Contains(id);
        }
	}
}