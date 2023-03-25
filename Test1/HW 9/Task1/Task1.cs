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

			//Task 1.2
			List<Product> products3 = new List<Product>
			{
				new AvailableProducts("Hleb", 500, new DateTime(2023, 3, 20), new DateTime(2023, 3, 15)),
				new AvailableProducts("Moloko", 100, new DateTime(2024, 6, 20), new DateTime(2023, 3, 15)),
				new AvailableProducts("Tvorog", 300, new DateTime(2023, 3, 15), new DateTime(2023, 3, 15)),
				new AvailableProducts("Pasta", 310, new DateTime(2023, 9, 10), new DateTime(2023, 1, 10)),
				new AvailableProducts("Potato", 1000, new DateTime(2023, 12, 31), new DateTime(2023, 2, 20)),
				new AvailableProducts("Sprite", 299, new DateTime(2024, 1, 15), new DateTime(2022, 12, 15)),
			};

			List<Product> productsWithHighPrice = new();

			foreach (var product in products3.ToList())
			{
				product.MoveElement(products3, productsWithHighPrice);
			}

			Console.WriteLine("\nProduct with price < 300: ");

			foreach (var product in products3.ToList())
			{
				product.getProductInfo();
			}

			Console.WriteLine("\nProducts with price > 300:");

			foreach (var product in productsWithHighPrice)
			{
				product.getProductInfo();
			}

			Console.WriteLine($"\nProduct with minimu price from new list: {productsWithHighPrice.Min()}");


			//Task 1.3
			var productAvailable = new Dictionary<Product, int>()
			{
				[new AvailableProducts("Hleb Narochanskiy")] = 200,
				[new AvailableProducts("Moloko Rogachevskoe")] = 150,
				[new AvailableProducts("Tvorog 101 zerno")] = 160,
				[new AvailableProducts("Pasta")] = 50,
				[new AvailableProducts("Cheese")] = 35,
				[new AvailableProducts("Sprite")] = 15,
				[new AvailableProducts("Sausage")] = 20,
			};
			Console.WriteLine("\nDictionary list with pairs of Names and Values: ");

			foreach (KeyValuePair<Product, int> product in productAvailable)
			{
				Console.WriteLine($"{product.Key}, Count = {product.Value}");
			}

			Console.WriteLine("\nDictionary list with Names only: ");

			foreach (KeyValuePair<Product, int> product in productAvailable)
			{
				Console.WriteLine($"{product.Key}");
			}

			Console.WriteLine("\nDictionary list with Values only: ");

			foreach (KeyValuePair<Product, int> product in productAvailable)
			{
				Console.WriteLine($"Count = {product.Value}");
			}

			Console.WriteLine("\nDictionary to List: ");

			List<KeyValuePair<Product, int>> DictionaryToList = productAvailable.ToList();

			Console.WriteLine(String.Join(",\n", DictionaryToList));
		}
	}
}

