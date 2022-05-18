namespace Kontejner.Models
{
	public abstract class Base
	{
		public static int Weight { get; private set; }
		public int Height { get; private set; }
		public int Length { get; private set; }
		public int Width { get; private set; }
		public double Volume { get; private set; }
		public double AvailableVolume { get; protected set; }

		public Base(int weight, int height, int length, int width)
		{
			Weight=weight;
			Height=height;
			Length=length;
			Width=width;
			AvailableVolume=Volume=height*length*width;
		}
	}
}