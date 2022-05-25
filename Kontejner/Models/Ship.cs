using System.Collections.Generic;

namespace Kontejner.Models
{
    public class Ship:Base
    {
        public List<Container> ContainersInside { get; set; }
        public string ShipId { get; set; }
        public Ship(Container container,int weight, int height,int length, int width):base(weight,height,length,width)
        {
            ContainersInside = new List<Container>();
            AddContainer(container);
        }
        public void AddContainer(Container container)
        {
            this.ContainersInside.Add(container);
        }
    }
}