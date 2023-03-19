using System;
using System.Collections;

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
		}
	}
}

