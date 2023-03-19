
using System;
using System.Text;

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

	//Написать программу со следующим функционалом: На вход передать строку(будем считать, что это номер документа). Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число, а y — это буква.
	//Вывести на экран в одну строку два первых блока по 4 цифры.
	//Вывести на экран номер документа, но блоки из трех букв заменить на*** (каждая буква заменятся на*).
	//Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.
	//Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью класса StringBuilder).
	//Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет(причем, abc и ABC считается одинаковой последовательностью).
	//Проверить начинается ли номер документа с последовательности

	public static void Task5()
	{
		string documentNumber = "1234-abc-5678-XYZ-xyZw";

		// Выводим два первых блока по 4 цифры
		Console.WriteLine(documentNumber.Substring(0, 4) + "-" + documentNumber.Substring(9, 4));

		// Заменяем блоки из трех букв на ***
		//string replaceLetters = documentNumber;
		//for (int i = 0; i < replaceLetters.Length; i++)
		//{
		//	if (i == '-')
		//	{
		//		replaceLetters = replaceLetters.Remove(i, 3).Insert(i, "***");
		//	}
		//}
		//Console.WriteLine(replaceLetters);

		// Выводим только буквы в формате yyy/yyy/y/y
		string lettersOnly = "";
		for (int i = 0; i < documentNumber.Length; i++)
		{
			if (Char.IsLetter(documentNumber[i]))
			{
				lettersOnly += documentNumber[i];
			}
		}
		Console.WriteLine(lettersOnly.Substring(0, 3) + "/" + lettersOnly.Substring(3, 3) + "/" + lettersOnly.Substring(6, 1) + "/" + lettersOnly.Substring(7, 1));

		// Выводим буквы в формате "Letters:yyy/yyy/y/y" в верхнем регистре
		StringBuilder sb = new StringBuilder("Letters:");
		for (int i = 0; i < documentNumber.Length; i++)
		{
			if (Char.IsLetter(documentNumber[i]))
			{
				sb.Append(Char.ToUpper(documentNumber[i]));
			}
			else
			{
				sb.Append(documentNumber[i]);
			}
		}
	}
}
