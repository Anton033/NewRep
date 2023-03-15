using System;
namespace Test1.Classes
{
	public class Buss
	{
		public string Destination { get; set; }
		public int Number { get; set; }
		public DateTime DepartureTime { get; set; }
		public int NumberOfSeats { get; set; }
	}

	public abstract class Transport
	{
		public abstract string GetType();
	}

	public class Electric : Transport
	{
		public override string GetType()
		{
			return "Electric";
		}
	}

	public class Rail : Transport
	{
		public override string GetType()
		{
			return "Rail";
		}
	}

	//public class ICE : Transport
	//{
	//	public override string GetType()
	//	{
	//		return "ICE";
	//	}
	//}

	public class Tram : Rail
	{
	}

	public class TrolleyBuss : Electric
	{
	}
}

