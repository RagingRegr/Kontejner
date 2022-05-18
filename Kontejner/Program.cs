using System;
using System.Collections.Generic;
using Kontejner.Models;
using Kontejner.Helpers;

namespace Kontejner
{
	internal class Program
	{
		public const int BoxAmount = 20;
		public static List<Box> Boxes = new List<Box>();
		public static List<Container> Containers = new List<Container>();
		static void Main(string[] args)
		{
			Container container = Helpers.Helpers.CreateContainer();
			AddBoxesUntilFull(container, BoxAmount);

		}

		private static void AddBoxesUntilFull(Container container, int boxAmount)
		{
			for (int i = 0; i < BoxAmount; i++)
			{
				Box box = Helpers.Helpers.CreateBox();
				Boxes.Add(box);
				Console.WriteLine($"Box has {Box.Weight}kg and volume {Box.Volume}cm");
				if (container.SizeCheck(Boxes[i]))
				{
					Console.WriteLine("Container is full.");
					Boxes.RemoveAt(i);
					Containers.Add(container);
					Container NewContainer = Helpers.Helpers.CreateContainer();
					AddBoxesUntilFull(NewContainer, BoxAmount - i);
					break;
				}
				container.AddBox(Boxes[i]);
				container.ContainerSpaceLeft();
			}
		}

	}
}
