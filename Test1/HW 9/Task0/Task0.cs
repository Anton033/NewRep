using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Test1.HW9.Task0
{
	internal class Task0
	{
		public static void ZeroTask()
		{
			ArrayList list = new ArrayList();

			try
			{
				object? s = list[18];
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

