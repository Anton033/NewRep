
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
    //Task0
    public static void Task0()
    {

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Your array is: ");

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


    //Task1
    public static void Task1()
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


    //Task2
    public static void Task2()
    {

        Random random = new Random();

        Console.WriteLine("\nEnter the size of your array: ");
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


    //Task3
    public static void Task3()
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


    //Дополнительное задание
    //4. Создайте массив из n случайных целых чисел и выведите его на экран.
    //Размер массива пусть задается с консоли и размер массива может быть больше 5 и меньше или равно 10.
    //Если n не удовлетворяет условию - выведите сообщение об этом. Если пользователь ввёл не подходящее число, то программа должна просить пользователя повторить ввод.
    //Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.

    public static void Task4()
    {
        Random random = new Random();

        Console.Write("\nEnter the size of your array: ");
        int size = int.Parse(Console.ReadLine()); //Задаем размерность массива

        int[] numbers = new int[size];

        if (size > 5 && size <= 10)
        {
            Console.WriteLine("\nYour array is: ");
            for (int i = 0; i < numbers.Length; i++) //Заполняем массив если размер больше 5, но меньше либо равен 10
            {
                numbers[i] = (int)random.NextInt64(-10, 10);
                Console.Write(numbers[i] + " ");
            }
        }
        else
        {
            Console.WriteLine("\nTry again plz ");
        }

        int[] NewArray = new int[numbers.Length]; //Новый массив с таким же размером
        int j = 0;

        for (int i = 0; i < numbers.Length; i++) //Цикл сравнения элементов первого массива, если четный - записываем во второй массив
        {
            if (numbers[i] % 2 == 0)
            {
                NewArray[j] = numbers[i];
                j++;
            }
        }

        Console.WriteLine("\n New Array is: "); //Вывод нового массива
        for (int i = 0; i < j; i++)
        {
            Console.Write(NewArray[i] + " ");
        }
    }



    //5. Создайте массив и заполните массив.
    //Выведите массив на экран в строку.
    //Замените каждый элемент с нечётным индексом на ноль.
    //Снова выведете массив на экран на отдельной строке.

    public static void Task5()
    {
        Random random = new Random();

        int[] numbers = new int[5];


        Console.WriteLine("\n Your default array is: ");
        for (int i = 0; i < numbers.Length; i++)  // Заполняем первый массив
        {
            numbers[i] = (int)random.NextInt64(-10, 10);
            Console.Write(numbers[i] + " ");

        }

        for (int i = 0; i < numbers.Length; i++) // Цикл с проверкой остатка от деления индекса на 2
        {
            if (i % 2 != 0)
            {
                numbers[i] = 0;
            }
           
        }

        Console.WriteLine("\nYour new array is: ");

        for (int i = 0; i < numbers.Length; i++) //Вывод нового массива
        {
            Console.Write(numbers[i] + " ");
        }
            


    }
}


