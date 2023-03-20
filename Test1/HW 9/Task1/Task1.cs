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
			Console.WriteLine("\n");


			//Task 1.1
			List<Product> products2 = new List<Product>
			{
				new AvailableProducts("Hleb Narochanskiy", 10, new DateTime(2023, 3, 20), new DateTime(2023, 3, 15)),
				new AvailableProducts("Moloko Rogachevskoe", 5, new DateTime(2024, 6, 20), new DateTime(2023, 3, 15)),
				new AvailableProducts("Tvorog 101 zerno", 13, new DateTime(2023, 3, 15), new DateTime(2023, 3, 15)),
				new AvailableProducts("Chocolate", 15, new DateTime(2023, 9, 10), new DateTime(2023, 1, 10)),
				new AvailableProducts("Ice Cream", 2, new DateTime(2023, 12, 31), new DateTime(2023, 2, 20)),
				new AvailableProducts("Coca-Cola", 3, new DateTime(2024, 1, 15), new DateTime(2022, 12, 15)),
			};

			Console.WriteLine("\nNew Product List:");
			foreach(Product product2 in products2)
			{
				product2.getProductInfo();
			}

			//Change the price of one product by 100
			products2[1] = new AvailableProducts("Moloko Rogachevskoe", 105, new DateTime(2024, 6, 20), new DateTime(2023, 3, 15));

			//Delete the last product.
			products2.RemoveAt(products2.Count - 1);

			Console.WriteLine("\n");
			Console.WriteLine("New Product List after actions:");

			foreach (Product product2 in products2)
			{
				product2.getProductInfo();
			}

			//Deleting all products

			products2.Clear();

			Console.WriteLine("\n");
			Console.WriteLine("Empty???");

			foreach (Product product2 in products2)
			{
				product2.getProductInfo();
			}
		}
	}
}

