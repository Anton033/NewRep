
//Основное задание
//0. Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.
//Пусть число для поиска задается с консоли.


//1. Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
//Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.
//В результате должен быть новый массив без указанного числа.

//2. Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
//Для генерации случайного числа используйте метод Random() . Пусть будет возможность создавать массив произвольного размера.
//Пусть размер массива вводится с консоли.

//3. Создайте 2 массива из 5 чисел.
//Выведите массивы на консоль в двух отдельных строках.
//Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось больше
//(либо сообщите, что их средние арифметические равны).


using System;

internal class HomeTask3
{
    //Task1
    public static void Task1()
    {
        Random random = new Random();

        int[] numbers = new int[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = (int)random.NextInt64(-100, 100);
            Console.WriteLine(numbers[i] + " ");

        }


        Console.WriteLine("Enter your number: ");
        int variable = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int i = 0; i < numbers.Length; i++)
        {

            if (variable == numbers[i])
            {
                isFound = true;
                Console.WriteLine("This number exists in the array");
            }

        }
        if (!isFound)
        {
            Console.WriteLine("Not this time buddy");
        }
    }

    //Task2
    public static void Task2()
    {


        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Enter a nubmer: ");
        int candidate = int.Parse(Console.ReadLine());

        int BeforeDel = numbers.Length;

        int[] NewArray = new int[BeforeDel];

        int j = 0;

        for (int i = 0; i < BeforeDel; i++)
        {
            if (numbers[i] != candidate)
            {
                NewArray[j] = numbers[i];
                j++;
            }
        }

        int AfterDel = j;

        if (BeforeDel == AfterDel)
        {
            Console.WriteLine("Entered number doesn't appear in the array");
        }
        else
        {
            Console.WriteLine("Array after deleting the number:");
            for (int i=0; i < AfterDel; i++)
            {
                Console.Write(NewArray[i] + " ");
            }
        }

    }
}



