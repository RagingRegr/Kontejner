using System;

namespace Kontejner.Models
{
	public class Box : Base
	{
		public Guid BoxID { get; private set; }
		public Box(int weight, int height, int length, int width) : base(weight, height, length, width)
		{
			BoxID = Guid.NewGuid();
		}

	}
}