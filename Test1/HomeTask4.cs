
internal class HomeTask4
{

	//Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.

	public static void Task1()
	{
		string text = "test in proggress take your time while doing test and test is in proggress or get 443 Error";
		Console.WriteLine($"Your text is: \n{text}");

		text = text.Replace("test", "testing");

		string replace = "";
		for (int i = 0; i < text.Length; i++)
		{
			if (!char.IsDigit(text[i]))
			{
				replace = replace + text[i];
			}
		}
		Console.WriteLine($"The result is: \n{replace}");
	}
}
