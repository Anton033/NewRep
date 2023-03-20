using System;
namespace Test1.HW9.Task1
{
	public class Set : Product
	{
		public string productList { get; set; }

		public Set(string ProductName, int ProductPrice, DateTime ExpDate, string ProductList, DateTime ManDate) : base(ProductName, ProductPrice, ExpDate, ManDate)
		{
			productList = ProductList;
		}

		public override void getProductInfo()
		{
			base.getProductInfo();
			Console.Write(", Category: " + productList);
		}
	}
}

