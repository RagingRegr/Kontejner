using System.Collections.Generic;

namespace Kontejner.Models
{
    public class Ship:Base
    {
        public static List<string> ShipIds = new List<string>();
        public List<Container> ContainersInside { get; set; }
        public string shipID    { get; set; }
        public Ship(Container container,int weight, int height,int length, int width):base(weight,height,length,width)
        {
            ContainersInside = new List<Container>();
            AddContainer(container);
            shipID = GetId(ShipIds);
        }
        public void AddContainer(Container container)
        {
            this.ContainersInside.Add(container);
            container.Location = this;
        }
    }
}