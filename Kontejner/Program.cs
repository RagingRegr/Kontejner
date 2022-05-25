using System;
using System.Collections.Generic;
using System.Net.Security;
using Kontejner.Models;
using Kontejner.Helpers;
using ConsoleTables;

namespace Kontejner
{
    internal class Program
    {
        public const int shipcount = 3;
        public const int BoxAmount = 100;
        public static List<Box> Boxes = new List<Box>();
        public static List<Container> Containers = new List<Container>();

        static void Main(string[] args)
        {
            Container container = Helpers.Helpers.CreateContainer();
            Box initialBox = null;
            container.GetContainerSpace();
            AddBoxesUntilFull(container, BoxAmount, initialBox);
            Console.WriteLine("HOTOVO!!!!!!!");
            Port port = new Port(shipcount);

            for (int i = 0; i < shipcount; i++)
            {
	            port.AddShip(new Ship(container,1000,100,100,100));
            }
            port.MoveContainer(1, 0, 1);

      Console.WriteLine("Please select \n1 for a table of all boxes\n2 to move a container \n3 to unload a container to the dock");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
	            case 1:
	            {
		            ConsoleTable table = new ConsoleTable("ShipID","ContainerID", "Total Boxes", "Total Weight");
		            foreach (Container containercount in Containers)
		            {
			            containercount.GetTable(table,container);
		            }
                    table.Write();
                    Console.WriteLine("Ships");
                    foreach (Ship ship in port.Ships)
                    {
                        Console.WriteLine(container.Location.shipID);
                    }
	            }
		            break;
	            case 2:
	            {
		            string containerId, shipId;
		            do
		            {
			            Console.WriteLine("Enter the container you want to move");
                  containerId= Console.ReadLine();
		            } while (container.ContainerID.Contains(containerId)==false);

		            do
		            {
              Console.WriteLine("Enter the ship you want to move it to");
              shipId = Console.ReadLine();
            } while (shipId==null);
	            }
		            break;
	            case 3:
	            {

	            }
		            break;
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
                container.AddWeight(box.Weight);

                Console.WriteLine(container.GetContainerSpace());
                initialBox = null;
            }
        }
    }
}
