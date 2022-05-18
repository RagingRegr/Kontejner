using System;
using Kontejner.Models;

namespace Kontejner.Helpers
{
	public class Helpers
	{
		public static Box CreateBox()
		{
			int weight = Randomizer(1, 25);
			int height = Randomizer(1, 25);
			int length = Randomizer(1, 25);
			int width = Randomizer(1, 25);

			return new Box(weight, height, length, width);
		}
		public static Container CreateContainer()
		{
			int weight = Randomizer(10, 50);
			int height = Randomizer(10, 50);
			int length = Randomizer(10, 50);
			int width = Randomizer(10, 50);

			return new Container(weight, height, length, width);
		}
		public static int Randomizer(int min, int max)
		{
			Random rand = new Random();
			return rand.Next(min, max);
		}

	}
}