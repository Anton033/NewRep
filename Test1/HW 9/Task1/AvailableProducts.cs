using System;
namespace Test1.HW9.Task1
{
	public class AvailableProducts : Product
	{
		public AvailableProducts(string ProductName, int ProductPrice, DateTime ExpDate, DateTime ManDate) : base(ProductName, ProductPrice, ExpDate, ManDate)
		{
		}

		public AvailableProducts(string ProductName, int ProductPrice) : base(ProductName, ProductPrice)
		{
		}

		public AvailableProducts(string ProductName) : base(ProductName)
		{
		}

		public override void getProductInfo()
		{
			base.getProductInfo();
		}
	}
}

