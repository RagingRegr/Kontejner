using System.Collections.Generic;

namespace Kontejner.Models
{
    public class Ship
    {
        private List<Container> ShipContainer { get; set; }
        public Ship(Container container)
        {
            ShipContainer = new List<Container>();
        }
        public void AddContainer(Container container)
        {
            this.ShipContainer.Add(container);
        }
    }
}