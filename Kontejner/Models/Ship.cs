using System.Collections.Generic;

namespace Kontejner.Models
{
    public class Ship
    {
        private List<Container> ContainersInside { get; set; }
        public Ship(Container container)
        {
            ContainersInside = new List<Container>();
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public void AddContainer(Container container)
        {
            this.ContainersInside.Add(container);
        }
    }
}