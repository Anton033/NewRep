using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test1.Classes
{
	internal class Phone
	{
		public string nubmer;
		public string model;
		public double weight;

		public Phone(string nubmer, string model, double weight)
		{
			this.nubmer = nubmer;
			this.model = model;
			this.weight = weight;
		}

		public Phone(string nubmer, string model) : this(nubmer, model, 0)
		{

		}

		public Phone()
		{

		}

		public void recieveCall(string CallerName)
		{
			Console.WriteLine($"Звонит {CallerName}");
		}

		public void recieveCall(string CallerName, string CallerNum)
		{
			Console.WriteLine($"Звонит {CallerName}, {CallerNum}");
		}

		public void sendMessage(params string[] phoneNumbers)
		{
			Console.WriteLine("Отправляю сообщение на номера:");
			foreach (string nubmer in phoneNumbers)
			{
				Console.WriteLine(nubmer);
			}
		}

		public string GetNubmer()
		{
			return nubmer;
		}

		public void Getinfo()
		{
			Console.WriteLine($"Number: {nubmer}, Model: {model}, Weight: {weight}");
		}
	}

}