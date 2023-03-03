
using System;

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
		Console.WriteLine();
		Console.WriteLine(AllWords);

	}

	//Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
	//Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
	//Результат вывести в консоль.

	public static void Task3()
	{

		string text = "teamwithsomeofexcersicesabcwanttomakeitbetter.";

		string searchABC = "abc";

		int indexOfABC = text.IndexOf(searchABC);

		string substring1 = text.Substring(0, indexOfABC);

		string substring2 = text.Substring(indexOfABC + 3);
		Console.WriteLine();
		Console.WriteLine(substring1 + " " + substring2);

	}

	//Дана строка: Плохой день.
	//Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
	//Заменить последний "!" на "?"

	public static void Task4()
	{
		string text = "Плохой день";
		string search = "Плохой";

		int index = text.IndexOf(search);

		string substring1 = text.Substring(index + 6);

		string substring2 = substring1.Insert(index, "Хороший") + "!!!!!!!!!";
		
		substring2 = substring2.Remove(substring2.Length - 1) + "?";
		Console.WriteLine();
		Console.WriteLine(substring2);
	}
}
