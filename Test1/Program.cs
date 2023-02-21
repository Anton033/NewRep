using System;

internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
    }

    public static void Task1()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello World!");
        Console.WriteLine("Helloy " + name);
    }

    public static void Task2()
    {
        int operand1 = 5;
        int operand2 = 4;
        string action = Console.ReadLine();

        switch (action)
        {
            case "*":
                Console.WriteLine($"The result is: {operand1} * {operand2} = {operand1* operand2}");
                //Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                break;

            case "/":
                Console.WriteLine($"The result is: {operand1} / {operand2} = " + (operand1 / operand2));
                break;

            case "-":
                Console.WriteLine($"The result is: {operand1} - {operand2} = " + (operand1 - operand2));
                break;

            case "+":
                Console.WriteLine($"The result is: {operand1} + {operand2} = " + (operand1 + operand2));
                break;

        }


    


    }

}