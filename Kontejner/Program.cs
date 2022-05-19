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
            Box initialBox = null;
            container.GetContainerSpace();
            AddBoxesUntilFull(container, BoxAmount,initialBox);
            Console.WriteLine("HOTOVO!!!!!!!");
            Console.WriteLine($"Pocet kontejneru je {Containers.Count}");
            foreach (Container containercount in Containers)
            {
                Console.WriteLine($"pocet krabic je {containercount.GetContent().Count}");
            }
        }

		private static void AddBoxesUntilFull(Container container, int BoxAmount, Box initialBox)
		{
            Containers.Add(container);
            Box box;
            for (int i = 0; i < BoxAmount; i++)
            {
                if (initialBox == null)
                     box = Helpers.Helpers.CreateBox();
                else
                    box = initialBox;
			    Boxes.Add(box);

				Console.WriteLine($"Box has {box.Weight}kg and volume {box.AvailableVolume}cm");
				if (container.SizeCheck(Boxes[i]))
				{
					Console.WriteLine("Container is full.");
                    Box remainingBox = box;
					Boxes.RemoveAt(i);
                    Container NewContainer = Helpers.Helpers.CreateContainer();
					AddBoxesUntilFull(NewContainer, BoxAmount - i, remainingBox);
					break;
				}
				container.AddBox(Boxes[i]);
				Console.WriteLine(container.GetContainerSpace());
                initialBox = null;
            }
		}

	}
}
