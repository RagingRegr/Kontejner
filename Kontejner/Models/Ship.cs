using System.Collections.Generic;

namespace Kontejner.Models
{
    public class Ship
    {
        public List<Container> ContainersInside { get; set; }
        public Ship(Container container)
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