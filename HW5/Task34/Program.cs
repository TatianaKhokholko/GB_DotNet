/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

public static class Program
{
    public static void Main()
    {
        int number = Terms("Input three-digit number\t");
        int[] countArrayNumber = new int[number];
        int[] finalArray = FillingArray(countArrayNumber);
        CheckForNumberOfEvenNumbersInArray(finalArray);
    }

    private static void CheckInputNumberIsValid(int number)
    {
        if (number > 0) { }
        else
        {
            Console.WriteLine("\nThe input number not valid!");
            Environment.Exit(0);
        }
    }

    private static int Terms(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        CheckInputNumberIsValid(number);
        return number;
    }

    private static int[] FillingArray(int[] countArrayNumber)
    {
        string separate = ", ";

        Console.Write("The array -> [");
        for (int i = 0; i < countArrayNumber.Length; i++)
        {
            countArrayNumber[i] = new Random().Next(99, 1000);
            if (i < countArrayNumber.Length - 1)
            {
                Console.Write(countArrayNumber[i] + separate);
            }
            else
            {
                Console.Write(countArrayNumber[i]);
            }
        }
        Console.WriteLine("]");
        return countArrayNumber;
    }

    private static void CheckForNumberOfEvenNumbersInArray(int[] finalArray)
    {
        int countEven = 0;
        for (int i = 0; i < finalArray.Length; i++)
        {
            if (finalArray[i] % 2 == 0)
            {
                Console.WriteLine($"The number is {finalArray[i]}");
                countEven++;
            }
            else { }
        }
        Console.Write($"Count even numbers= {countEven}");
    }
}
