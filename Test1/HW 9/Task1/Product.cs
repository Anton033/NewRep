using System;
namespace Test1.HW9.Task1
{
	public class Product : ICheckPrice, IComparable<Product>
	{
		public string productName { get; set; }
		public int productPrice { get; set; }
		public DateTime expDate { get; set; }
		public DateTime manDate { get; set; }

		public Product(string ProductName, int ProductPrice, DateTime ExpDate, DateTime ManDate)
		{
			productName = ProductName;
			productPrice = ProductPrice;
			expDate = ExpDate;
			manDate = ManDate;
		}

		public virtual void getProductInfo()
		{
			Console.Write("\nProduct info: " + productName + ", " + productPrice + "$, Expiration date - " + expDate + ", Manufactured date - " + manDate);
		}

		public bool IsExpired()
		{
			return DateTime.Today > expDate;
		}

		public string ICheckPrice300()
		{
			if (productPrice > 300)
			{
				return "true";
			}
			return "false";
		}

		public void MoveElement(List<Product> one, List <Product> two)
		{
			foreach (var product in one.ToList())
			{
				if (product.ICheckPrice300().Contains("true"))
				{
					two.Add(product);
					one.Remove(product);
				}
			}
		}

		int IComparable<Product>.CompareTo(Product other)
		{
			if (other.productPrice > this.productPrice)
			{
				return -1;
			}
			else if (other.productPrice == this.productPrice)
			{
				return 0;
			}
			else
			{
				return 1;
			}
		}

		public override string ToString()
		{
			return string.Format($"{productName}");
		}

	}
}

