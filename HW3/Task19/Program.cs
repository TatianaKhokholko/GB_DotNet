/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

public static class Programm
{
    public static void Main()
    {
        Console.WriteLine("Input five-digit number and press enter");
        string? number = Console.ReadLine();
        CheckLengthAndPrintResult(number);
    }

    private static void CheckLengthAndPrintResult(string number)
    {
        if (number?.Length == 5)
        {
            if (number[0] == number[4] && number[1] == number[3])
            {
                Console.WriteLine($"{number} is palindrome");
            }
            else Console.WriteLine($"{number} is not palindrome");
        }
        else
        {
            Console.WriteLine($"The number isn't five-digit!");
        }
    }
}