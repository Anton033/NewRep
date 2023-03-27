using System;
using System.Collections;

namespace Test1.HW10.HW10Program
{
	internal class HW10Program
	{
		public static void TaskMain()
		{
			Generic<int> Array = new Generic<int>();
			Array.AddToArray(1);
			Array.AddToArray(2);
			Array.AddToArray(3);
			Array.AddToArray(4);
			Array.AddToArray(5);

			Console.WriteLine("Length of Array: " + Array.Length);
			Console.WriteLine("Get elemnt witn 0 index: " + Array.GetArrayItem(0));

			Array.RemoveFromArray(1);

			Console.WriteLine("Get element at index 2 after removing element: " + Array.GetArrayItem(3));

			foreach (var element in Array)
			{
				Console.WriteLine(element);
			}

		}
	}
}

