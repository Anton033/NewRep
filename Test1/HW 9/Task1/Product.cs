using System;
namespace Test1.HW9.Task1
{
	public class Product
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


	}
}

