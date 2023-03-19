using System;
using System.Collections;
using System.Xml.Linq;

namespace Test1.Task0.HW9
{
	internal class Task0
	{
		static void Main()
		{
			ArrayList list = new ArrayList();

			try
			{
				object s = list[18];
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine(ex.GetType().Name);
				Console.WriteLine($"Message: {ex.Message}");
			}

			Dictionary<string, int> list2 = new Dictionary<string, int>();

			list2.Add("one", 1);
			list2.Add("two", 2);
			list2.Add("three", 3);
			list2.Add("four", 4);
			list2.Add("five", 5);
			list2.Add("six", 6);
			list2.Add("seven", 7);
			list2.Add("eight", 8);
			list2.Add("nine", 9);
			list2.Add("ten", 10);

			Console.WriteLine($"\nCollection content:");

			foreach (var element in list2)
			{
				Console.WriteLine(element);
			}
		}
	}
}

