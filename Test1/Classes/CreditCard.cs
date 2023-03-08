using System;
namespace Test1.Classes
{
	public class CreditCard
	{

		public string cardNumber;
		public double cardBalance;

		public CreditCard(string cardNumber, double cardBalance)
		{
			this.cardNumber = cardNumber;
			this.cardBalance = cardBalance;
		}

		public void getInfo()
		{
			Console.WriteLine($"Your card nubmer -> {cardNumber} \nyour currecnt ballance -> {cardBalance}");
		}

		public void addMoney(double addBalance)
		{
			cardBalance += addBalance;
		}

		public void moneyWithdrawal(double removeMoney)
		{
			cardBalance -= removeMoney;
		}

	}
}

