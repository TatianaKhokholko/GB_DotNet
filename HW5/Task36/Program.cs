/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

public static class Program
{
    public static void Main()
    {
        int arrayLength = Terms("Input length for array\t");
        int[] array = new int[arrayLength];
        int[] finalArray = FillingArray(array);
        CountSumNotEvenNumbers(finalArray);
    }

    private static void CheckInputNumberIsValid(int number)
    {
        if (number > 0 && number != null) { }
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
            countArrayNumber[i] = new Random().Next(0, 100);
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

    private static void CountSumNotEvenNumbers(int[] finalArray)
    {
        int sum = 0;
        for (int i = 0; i < finalArray.Length; i++)
        {
            if (finalArray[i] % 2 != 0)
            {
                Console.WriteLine($"The number is {finalArray[i]}");
                sum += finalArray[i];
            }
            else { }
        }
            Console.Write($"Sum not even numbers = {sum}");
    }
}
