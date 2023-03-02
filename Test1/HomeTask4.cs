
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

	//Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
	//Welcome to the TMS lesons.
	//Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова

	public static void Task2()
	{
		string word1 = "\"Welcome\"";
		string word2 = "\"to\"";
		string word3 = "\"the\"";
		string word4 = "\"TMS\"";
		string word5 = "\"lesons.\"";

		string[] array = new string[] { word1, word2, word3, word4, word5, };

		string AllWords = string.Join(" ", array);

		AllWords = AllWords.Replace("\"", "");

		Console.Write(AllWords);
	}
}
