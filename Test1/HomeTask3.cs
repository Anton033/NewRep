
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

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }


        Console.WriteLine("\nEnter your number: ");
        int variable = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int i = 0; i < numbers.Length; i++) //Сравнивем каждый элемент с введенным значением, если нашли - выводим 
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

        Console.WriteLine("\nEnter a nubmer: ");
        int NumToDel = int.Parse(Console.ReadLine());

        int BeforeDel = numbers.Length; // Сохраняем количество элементов массива до удаления

        int[] NewArray = new int[BeforeDel]; // Создаем новый массив той же длины, что и исходный

        int j = 0; // Индекс текущего элемента нового массива

        for (int i = 0; i < BeforeDel; i++)
        {
            if (numbers[i] != NumToDel)
            {
                NewArray[j] = numbers[i];
                j++;
            }
        }

        int AfterDel = j; // Сохраняем количество элементов нового массива после добавления

        if (BeforeDel == AfterDel)
        {
            Console.WriteLine("Entered number doesn't appear in the array");
        }
        else
        {
            Console.WriteLine("Array after deleting the number:");
            for (int i = 0; i < AfterDel; i++)
            {
                Console.Write(NewArray[i] + " ");
            }
        }

    }


    //Task3
    public static void Task3()
    {

        Random random = new Random();

        Console.Write("\nEnter the size of your array: "); 
        int size = int.Parse(Console.ReadLine()); //Задаем размерность массива

        int[] numbers = new int[size];

        Console.WriteLine("\nYour array is: ");
        for (int i = 0; i < numbers.Length; i++) //Заполняем массив
        {
            numbers[i] = (int)random.NextInt64(-100, 100);
            Console.Write(numbers[i] + " ");
        }

        int MaxNum = numbers[0];
        int MinNum = numbers[0];

        for (int i = 0; i < numbers.Length; i++) //Цикл сравнения элементов
        {
            if (MaxNum < numbers[i])
            {
                MaxNum = numbers[i];
            }
            if (MinNum > numbers[i])
            {
                MinNum = numbers[i];
            }
        }

        double Sum = 0;
        double AvNum;

        for (int i = 0; i < numbers.Length; i++) //Цикл наъождения суммы всех элементов
        {
            Sum = Sum + numbers[i];
        }

        AvNum = Sum / numbers.Length;


        Console.WriteLine($"\nMax element is {MaxNum}, Min element is {MinNum}, Average of all elements is {AvNum}");

    }


    //Task4
    public static void Task4()
    {
        Random random = new Random();

        int[] numbers1 = new int[5];

        Console.WriteLine("\nYour 1st array is: ");
        for (int i = 0; i < numbers1.Length; i++)  // Заполняем первый массив
        {
            numbers1[i] = (int)random.NextInt64(-10, 10);
            Console.Write(numbers1[i] + " ");
        }

        double SumNum1 = 0;
        double AvNum1;

        for (int i = 0; i < numbers1.Length; i++) // Находим сумму всех элементов для первого массива
        {
            SumNum1 = SumNum1 + numbers1[i];
        }

        AvNum1 = SumNum1 / numbers1.Length;   // Вычисляем среднее значение первого массива
        Console.WriteLine($"\nAverage value for 1st array is: {AvNum1}");

        int[] numbers2 = new int[5];

        Console.WriteLine("\nYour 2nd array is: "); 
        for (int i = 0; i < numbers1.Length; i++) // Заполняем второй массив
        {
            numbers1[i] = (int)random.NextInt64(-10, 10);
            Console.Write(numbers1[i] + " ");
        }

        double SumNum2 = 0;
        double AvNum2;

        for (int i = 0; i < numbers2.Length; i++) // Находим сумму всех элементов для второго массива
        {
            SumNum2 = SumNum2 + numbers2[i];
        }

        AvNum2 = SumNum2 / numbers2.Length;  // Вычисляем среднее значение второго массива
        Console.WriteLine($"\nAverage value for 1st array is: {AvNum2}");

        if (AvNum1 > AvNum2) //Сравниваем
        {
            Console.WriteLine($"\n Average value is bigger for 1st array");
        }

        else if (AvNum2 > AvNum1)
        {
            Console.WriteLine($"\n Average value is bigger for 2nd array");
        }
        else
        {
            Console.WriteLine($"\n Average values are equal");
        }
    }
}


