using System;

internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
    }

    public static void Task1()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello World!");
        Console.WriteLine("Helloy " + name);
    }



    /* Напишите программу - консольный калькулятор.
    Создайте две переменные с именами operand1 и operand2.
    Задайте переменным некоторые произвольные значения.
    Предложите пользователю ввести знак арифметической операции.
    Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
    Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
    Выведите на экран результат выполнения арифметической операции.
    **В случае использования операции деления, организуйте проверку попытки деления на ноль.
    И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя. */

    public static void Task2()
    {
        Console.WriteLine("Enter 1st value");
        int operand1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd value");
        int operand2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter an arithmetic operation");
        string sign = Console.ReadLine();

        switch (sign)
        {
            case "*":
                Console.WriteLine($"The result is: {operand1} * {operand2} = {operand1 * operand2}");
                break;

            case "/":
                if (operand2 == 0)
                {
                    Console.WriteLine("ERROR");
                }

                else
                {
                    Console.WriteLine($"The result is: {operand1} / {operand2} = " + (operand1 / operand2));
                }
                break;

            case "-":
                Console.WriteLine($"The result is: {operand1} - {operand2} = " + (operand1 - operand2));
                break;

            case "+":
                Console.WriteLine($"The result is: {operand1} + {operand2} = " + (operand1 + operand2));
                break;

            default:
                Console.WriteLine("Incorrect sign was entered");
                break;

        }
    }



    /*Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток[0 - 14][15 - 35][36 - 50][50 - 100].
    Если да, то укажите, в какой именно промежуток.
    Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение. */

    public static void Task3()
    {
        Console.WriteLine("Enter a value from 0 to 100");
        int a = int.Parse(Console.ReadLine());


        switch (a)
        {
            case >= 0 and <= 14:
                Console.WriteLine($"{a} somhere between 0 and 14");
                break;

            case >= 15 and <= 35:
                Console.WriteLine($"{a} somhere between 15 and 35");
                break;

            case >= 36 and <= 50:
                Console.WriteLine($"{a} somhere between 36 and 50");
                break;

            case >= 50 and <= 100:
                Console.WriteLine($"{a} somhere between 50 and 100");
                break;

            default:
                Console.WriteLine("Out of value range");
                break;

        }
    }


    /*Напишите программу русско-английский переводчик.
    Программа знает 10 слов о погоде.
    Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
    Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.*/

    public static void Task4()
    {
        Console.WriteLine("Enter ru word");

        string a = Console.ReadLine();


        switch (a)
        {
            case "дождь":
                Console.WriteLine($"{a} is rain in english");
                break;

            case "туман":
                Console.WriteLine($"{a} is fog in english");
                break;

            case "ветер":
                Console.WriteLine($"{a} is wind in english");
                break;

            case "солнечно":
                Console.WriteLine($"{a} is sunny in english");
                break;

            case "пасмурно":
                Console.WriteLine($"{a} is cloudly in english");
                break;

            case "торнадо":
                Console.WriteLine($"{a} is tornado in english");
                break;

            case "закат":
                Console.WriteLine($"{a} is sunset in english");
                break;

            case "восход":
                Console.WriteLine($"{a} is sunrise in english");
                break;

            case "влажность":
                Console.WriteLine($"{a} is humidity in english");
                break;

            case "давление":
                Console.WriteLine($"{a} is pressure in english");
                break;

            default:
                Console.WriteLine("Incorrect word");
                break;

        }


    }


    /*...Напишите программу, которая будет выполнять проверку чисел на четность.
    Предложите два варианта решения поставленной задачи.*/

    public static void Task5()
    {
        Console.WriteLine("Enter a number:");
        int a = int.Parse(Console.ReadLine());
        int b = 2;

        if (a % b == 0)
        {
            Console.WriteLine("Entered number is even");
        }

        else
        {
            Console.WriteLine("Entered number is not even");
        }
       
    }

}