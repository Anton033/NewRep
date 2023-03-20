using System;
using System.Collections.Generic;

namespace Test1.HW9.Task1
{
	internal class Task1
	{
		public static void FirstTask()
		{
			List<Product> products = new List<Product>
			{
				new AvailableProducts("Hleb Narochanskiy", 10, new DateTime(2023, 3, 20), new DateTime(2023, 3, 15)),
				new AvailableProducts("Moloko Rogachevskoe", 5, new DateTime(2024, 6, 20), new DateTime(2023, 3, 15)),
				new AvailableProducts("Tvorog 101 zerno", 13, new DateTime(2023, 3, 15), new DateTime(2023, 3, 15)),
				new Batch("Apples", 3, new DateTime(2023, 3, 10), new DateTime(2023, 1, 10), 15),
				new Batch("Water tanks", 5, new DateTime(2024, 8, 10), new DateTime(2022, 1, 1), 5),
				new Batch("Canned fish", 8, new DateTime(2028, 8, 10), new DateTime(2020, 4, 11), 50),

			};

			//Listing products and checking expired date
			foreach (Product product in products)
			{
				product.getProductInfo();

				if (product.IsExpired())
				{
					Console.WriteLine("\nThe expiration date has expired!!!");
				}
				else
				{
					Console.WriteLine("\nThe expiration date has not expired.");
				}
			}

			//Displaying a list of products with an expired date
			int expDateCounter = 0;
			Console.WriteLine("\nProducts with expired date: ");

			foreach (Product product in products)
			{
				if (product.IsExpired())
				{
					product.getProductInfo();
					expDateCounter++;
				}
			}
			if (expDateCounter == 0)
			{
				Console.WriteLine("\nThere are no product with expired date!");
			}
		}
	}
}

