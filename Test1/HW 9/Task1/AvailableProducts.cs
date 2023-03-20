using System;
namespace Test1.HW9.Task1
{
	public class AvailableProducts : Product
	{
		public AvailableProducts(string ProductName, int ProductPrice, DateTime ExpDate, DateTime ManDate) : base(ProductName, ProductPrice, ExpDate, ManDate)
		{
		}

		public override void getProductInfo()
		{
			base.getProductInfo();
		}
	}
}

