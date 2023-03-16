using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Classes;
using System.Text.RegularExpressions;

internal class Program
{
	static void Main()
	{
		////Task1
		//Phone phone1 = new Phone("+48123123123", "iPhone 13", 154);
		//Phone phone2 = new Phone("+48124124124", "iPhone 6");
		//Phone phone3 = new Phone();

		//Console.WriteLine("\nPhone 1:");
		//phone1.Getinfo();
		//phone1.recieveCall("Jhonny");
		//Console.WriteLine($"\nPhone number {phone1.GetNubmer()}");
		//phone1.sendMessage("+48123123123", "+48124124124", "+48125125125");

		//Console.WriteLine("\nPhone 2:");
		//phone2.Getinfo();
		//phone1.recieveCall("Jhonny", "+48124124124");

		//Console.WriteLine("\nPhone 3:");
		//phone3.Getinfo();


		////Task2
		//CreditCard card1 = new CreditCard("4444-3333-2222-1111-0000", 1000);
		//CreditCard card2 = new CreditCard("5555-0000-2222-1111-0000", 100);
		//CreditCard card3 = new CreditCard("0000-1111-2222-1111-0000", 13000);

		//Console.WriteLine("\nCard1:");
		//card1.getInfo();

		//Console.WriteLine("\nCard2:");
		//card2.getInfo();

		//Console.WriteLine("\nCard3:");
		//card3.getInfo();

		//card1.addMoney(10);

		//card2.addMoney(200);

		//card3.moneyWithdrawal(10000);

		//Console.WriteLine("\nCard1 after operation with balance:");
		//card1.getInfo();

		//Console.WriteLine("\nCard1 after operation with balance:");
		//card2.getInfo();

		//Console.WriteLine("\nCard1 after operation with balance:");
		//card3.getInfo();


		////Task3
		//CashMachine atm1 = new CashMachine(100, 20, 1);
		//atm1.getInfo();

		//Console.WriteLine("\nAfter adding money: ");
		//atm1.addMoney(5, 2, 3);

		//atm1.getInfo();

		//Console.WriteLine("\nAfter withdrawing money: ");

		//atm1.withdrawMoney(1220);

		//atm1.getInfo();

		//Task2
		//Patient p1 = new Patient(3, "Tom");
		//Patient p2 = new Patient(1, "Jack");
		//Patient p3 = new Patient(2, "Vasily");

		//Doc doc1 = p1.Plan();
		//doc1.Heal();

		//Doc doc2 = p2.Plan();
		//doc2.Heal();

		//Doc doc3 = p3.Plan();
		//doc3.Heal();

		////Task1
		//equilateralTriangle triangle1 = new equilateralTriangle(5, 5, 5);
		//Console.WriteLine(triangle1.GetSq());

		//StraightTriangle triangle3 = new StraightTriangle(6, 3, 4);
		//Console.WriteLine(triangle3.GetSq());

		//Triangle triangle4 = TriangleBuilder.CreateTriangle(1, 1, 3);

		//Square rectangle1 = new Square(2);
		//Rectangle rectangle2 = new Rectangle(3, 4);
		//Console.WriteLine(rectangle1.GetSquare());
		//Console.WriteLine(rectangle2.GetSquare());

		//Task3 //Point 1
		//Buss myBus = new Buss();
		//myBus.Destination = "New Yourk";
		//myBus.Number = 66;
		//myBus.DepartureTime = new DateTime(2023, 3, 10, 12, 30, 0);
		//myBus.NumberOfSeats = 16;

		//Console.WriteLine($"Buss number: {myBus.Number}");
		//Console.WriteLine($"Destination: {myBus.Destination}");
		//Console.WriteLine($"Departure Time: {myBus.DepartureTime}");
		//Console.WriteLine($"NumberOfSeats: {myBus.NumberOfSeats}");

		////Point 2
		//TrolleyBuss trolleyBuss = new TrolleyBuss();
		//Console.WriteLine(trolleyBuss.GetType());

		//Tram tram = new Tram();
		//Console.WriteLine(tram.GetType());

		////Point 3
		//Transport[] transports = new Transport[3];
		//transports[0] = new Buss() { Destination = "New Yourk", Number = 1, DepartureTime = new DateTime(2023, 3, 14, 11, 0, 0), NumberOfSeats = 18 };
		//transports[1] = new TrolleyBuss() { Destination = "San Francisco", Number = 2, DepartureTime = new DateTime(2023, 4, 11, 14, 0, 0), NumberOfSeats = 24 };
		//transports[2] = new Tram() { Destination = "Los Angeles", Number = 3, DepartureTime = new DateTime(2023, 3, 15, 11, 0, 0), NumberOfSeats = 10 };

		//Array.Sort(transports, (a1, a2) => a1.NumberOfSeats.CompareTo(a2.NumberOfSeats));

		//Console.WriteLine("\nSort results:");
		//foreach (Transport transport in transports)
		//{
		//	Console.WriteLine("Transport type: " + transport.GetType() + ", Number: " + transport.Number + ", Destination: " + transport.Destination + ", Departure Time: " + transport.DepartureTime + ", NumberOfSeats: " + transport.NumberOfSeats);
		//}

		//Console.WriteLine("\nEnter destination: ");
		//string searchDestination = Console.ReadLine();
		//Console.WriteLine("\nEnter departure time: ");
		//DateTime SearchTime = DateTime.Parse(Console.ReadLine());

		//Transport foundTransport = Array.Find(transports, a1 => a1.Destination == searchDestination && a1.DepartureTime == SearchTime);

		//if (foundTransport != null)
		//{
		//	Console.WriteLine("The results is: " + foundTransport.GetType() + ", Number: " + foundTransport.Number + ", Destination: " + foundTransport.Destination + ", Departure Time: " + foundTransport.DepartureTime + ", NumberOfSeats: " + foundTransport.NumberOfSeats);
		//}
		//else
		//{
		//	Console.WriteLine("Transport not found");
		//}

		////Point 4
		//Console.WriteLine("Enter a departure time to display a list of transport departing after it:");
		//DateTime SearchTime2 = DateTime.Parse(Console.ReadLine());

		//Console.WriteLine("\nTransport departing after " + SearchTime2 + ":");

		//int i = 0;
		//foreach (Transport transport in transports)
		//{
		//	if (transport.DepartureTime >= SearchTime2)
		//	{
		//		Console.WriteLine("Transport: " + transport.GetType() + ", Number: " + transport.Number + ", Destination: " + transport.Destination + ", Departure Time: " + transport.DepartureTime + ", NumberOfSeats: " + transport.NumberOfSeats);
		//		i++;
		//	}
		//}
		//if (i == 0)
		//{
		//	Console.WriteLine("No trasnport");
		//}



		//Task 4
		Auto[] cars = new Auto[6];
		cars[0] = new Sedan() { Brand ="Bentley Continental", Number = 1, Speed = 260, Weight = 1300 };
		cars[1] = new Truck() { Brand = "Volvo", Number = 4, Speed = 110, Weight = 3100, Trailer = "Yes"};
		cars[2] = new SUV() { Brand = "BMW X6", Number = 2, Speed = 210, Weight = 1800 };
		cars[3] = new SportBike { Brand = "Yamaha HJV", Number = 5, Speed = 310, Weight = 630, PassangerSeat = "Yes" };
		cars[4] = new Lorry() { Brand = "Mercedes-Benz p1000HQ", Number = 3, Speed = 140, Weight = 2300 };
		cars[5] = new Chopper() { Brand = "Harley Devidson", Number = 6, Speed = 190, Weight = 1050 };


		foreach (Auto car in cars)
		{
			Console.WriteLine("\nVehicle info: " + car.GetCarInfo() + ", Brand: " + car.Brand + ", Number: " + car.Number + ", Speed: " + car.Speed + ", Weight: " + car.Weight);
			Console.WriteLine("Vehicle load capacity: " + car.loadСapacity());
		}


		Console.WriteLine("\nEnter min capacity of the car: ");
		double SearchMinCapacity = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter max capacity of the car: ");
		double SearchMaxCapacity = double.Parse(Console.ReadLine());

		int a = 0;
		foreach (Auto car in cars)
		{
			if ((car.loadСapacity() >= SearchMinCapacity) && (car.loadСapacity() <= SearchMaxCapacity))
			{
				Console.WriteLine("\n Car Model: " + car.Brand + ", Type: " + car.GetCarInfo() + ", Car Capacity: " + car.loadСapacity());
				a++;
			}
		}
		if (a == 0)
		{
			Console.WriteLine("\nNo results");
		}
		
	}
}