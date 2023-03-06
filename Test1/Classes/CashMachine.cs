using System;
namespace Test1.Classes
{
	public class CashMachine
	{
		public int cashby20;
		public int cashby50;
		public int cashby100;

		public CashMachine(int cashby20, int cashby50, int cashby100)
		{
			this.cashby20 = cashby20;
			this.cashby50 = cashby50;
			this.cashby100 = cashby100;
		}

		public void addMoney(int cashby20, int cashby50, int cashby100)
		{
			this.cashby20 += cashby20;
			this.cashby50 += cashby50;
			this.cashby100 += cashby100;
		}

		public void getInfo()
		{
			Console.WriteLine($"\nAll by 20: {cashby20} \nAll by 50: {cashby50} \nAll by 100: {cashby100}");
		}

		public bool withdrawMoney(int amount)
		{
			if (amount % 10 != 0)
			{
				Console.WriteLine("Error: Invalid amount, must be multiple of 10");
				return false;
			}

			int num100 = Math.Min(amount / 100, cashby100);
			amount -= num100 * 100;

			int num50 = Math.Min(amount / 50, cashby50);
			amount -= num50 * 50;

			int num20 = Math.Min(amount / 20, cashby20);
			amount -= num20 * 20;

			if (amount == 0)
			{
				cashby100 -= num100;
				cashby50 -= num50;
				cashby20 -= num20;

				Console.WriteLine($"Withdrawn: {num100} x 100, {num50} x 50, {num20} x 20");
				return true;
			}
			else
			{
				Console.WriteLine("Error: Insufficient funds");
				return false;

			}

		}
	}
}

