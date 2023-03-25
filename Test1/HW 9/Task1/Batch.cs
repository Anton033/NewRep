using System;
namespace Test1.HW9.Task1
{
	public class Batch : Product
	{
		public int quantity { get; set; }


		public Batch(string ProductName, int ProductPrice, DateTime ExpDate, DateTime ManDate, int Quantity) : base(ProductName, ProductPrice, ExpDate, ManDate)
		{
			quantity = Quantity;
		}

		public override void getProductInfo()
		{
			base.getProductInfo();
			Console.Write(", Quantity: " + quantity);
		}
	}
}

