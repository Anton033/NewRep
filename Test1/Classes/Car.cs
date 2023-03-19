using System;
namespace Test1.Classes
{
	public abstract class Auto
	{
		public string Brand { get; set; }
		public int Number { get; set; }
		public double Weight  { get; set; }
		public int Speed { get; set; }

		public abstract string GetCarInfo();
		public abstract double loadСapacity();

	}

	public class PassengerCar : Auto
	{
		public override string GetCarInfo()
		{
			return "Passenger Car";
		}

		public override double loadСapacity()
		{
			return Weight / 3;
		}
	}

	public class FreightCar : Auto
	{
		public string Trailer { get; set; }
		public override string GetCarInfo()
		{
			return "Fright Car";
		}

		public override double loadСapacity()
		{
			if (Trailer != null)
			{
				return Weight * 2;
			}
			else
			{
				return Weight / 2;
			}
		}
	}

	public class Motorcycle : Auto
	{
		public string PassangerSeat { get; set; }

		public override string GetCarInfo()
		{
			return "Motorcycle";
		}

		public override double loadСapacity()
		{
			if (PassangerSeat != null)
			{
				return Weight / 5;
			}
			else
			{
				return Weight = 0;
			}
		}
	}

	public class SUV : PassengerCar
	{
	}

	public class Sedan : PassengerCar
	{
	}

	public class Truck : FreightCar
	{
	}

	public class Lorry : FreightCar
	{
	}

	public class SportBike : Motorcycle
	{
	}

	public class Chopper : Motorcycle
	{
	}




}

