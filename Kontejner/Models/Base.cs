namespace Kontejner.Models
{
	public abstract class Base
	{
		public static int Weight { get;protected set; }
		public int Height { get; protected set; }
		public int Length { get; protected set; }
		public int Width { get; protected set; }
		public static double Volume { get; protected internal set; }
		public Base(int weight, int height, int length, int width)
		{
			Weight=weight;
			Height=height;
			Length=length;
			Width=width;
			Volume=height*length*width;
		}
	}
}