/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

public static class Program
{
    public static void Main()
    {
        CountSumOfDigit();
    }

    private static int CountSumOfDigit()
    {
        string? inputNumber = Terms("Input any number\t");
        int digits = int.Parse(inputNumber);
        int progressStep = 0;
        int sumResult = 0;

        for (int i = 0; i < inputNumber.Length; i++)
        {
            progressStep = digits - digits %10;
            sumResult += (digits - progressStep);
            digits /= 10;
            Console.WriteLine(digits);
        }
        Console.WriteLine($"\nSum all digits of number {inputNumber} = {sumResult}");
        return sumResult;
    }

    private static string Terms(string message)
    {
        Console.Write(message);
        string? value = Console.ReadLine();
        return value;
    }
}
