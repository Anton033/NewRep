using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Classes
{
    internal class Program
    {
        static void Main()
		{
			Phone phone1 = new Phone("+48123123123", "iPhone 13", 154);
			Phone phone2 = new Phone("+48124124124", "iPhone 6");
			Phone phone3 = new Phone();

			Console.WriteLine("\nPhone 1:");
			phone1.Getinfo();
			phone1.recieveCall("Jhonny");
			Console.WriteLine($"\nPhone number {phone1.GetNubmer()}");
			phone1.sendMessage("+48123123123", "+48124124124", "+48125125125");

			Console.WriteLine("\nPhone 2:");
			phone2.Getinfo();
			phone1.recieveCall("Jhonny", "+48124124124");

			Console.WriteLine("\nPhone 3:");
			phone3.Getinfo();
		}

    }
}