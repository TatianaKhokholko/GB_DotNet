/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

 3 -> 1, 8, 27
 5 -> 1, 8, 27, 64, 125
*/

public static class Programm
{
    public static void Main()
    {
        Console.WriteLine("Input integer number");
        int number = int.Parse(Console.ReadLine());
        countPowAndPrintResult(number);
    }

    private static void countPowAndPrintResult(int inputValue)
    {
        Console.Write($"{inputValue} -> ");

        if (inputValue != 0)
        {
            for (int i = 1; i <= inputValue; i++)
            {
                Console.Write($"{Math.Pow(i, 3)}, ");
            }
        }
        else
        {
            Console.WriteLine("0 * 0 = 0\n=)");
        }
    }
}