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
		Patient p1 = new Patient(3, "Tom");
		Patient p2 = new Patient(1, "Jack");
		Patient p3 = new Patient(2, "Vasily");

		Doc doc1 = p1.Plan();
		doc1.Heal();

		Doc doc2 = p2.Plan();
		doc2.Heal();

		Doc doc3 = p3.Plan();
		doc3.Heal();

		//Task1
		equilateralTriangle triangle1 = new equilateralTriangle(5, 5, 5);
		Console.WriteLine(triangle1.GetSq());

		StraightTriangle triangle3 = new StraightTriangle(6, 3, 4);
		Console.WriteLine(triangle3.GetSq());

		Triangle triangle4 = TriangleBuilder.CreateTriangle(1, 1, 3);

		Square rectangle1 = new Square(2);
		Rectangle rectangle2 = new Rectangle(3, 4);
		Console.WriteLine(rectangle1.GetSquare());
		Console.WriteLine(rectangle2.GetSquare());
	}
}