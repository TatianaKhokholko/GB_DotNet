/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
(на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


public static class Program
{
    public static void Main()
    {
        PrintArray();
    }

    private static void PrintArray()
    {
        int arrayLength = Terms("Input an array length\t");
        CheckLengthForArray(arrayLength);

        int minValue = Terms("Input min value for array\t");
        int maxValue = Terms("Input max value for array\t");
        CheckMaxGreaterThanMin(minValue, maxValue);

        int[] arrayNumber = new int[arrayLength];
        string separate = ", ";

        Console.Write("[");
        for (int i = 0; i < arrayNumber.Length; i++)
        {
            arrayNumber[i] = new Random().Next(minValue, maxValue);
            if (i < arrayNumber.Length - 1)
            {
                Console.Write(arrayNumber[i] + separate);
            }
            else
            {
                Console.Write(arrayNumber[i]);
            }
        }
        Console.Write("]");
    }

    private static int Terms(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    private static void CheckLengthForArray(int length)
    {
        if (length > 0) { }
        else
        {
            Console.WriteLine("\nLength of array need more then zero!\nGo away!");
            Environment.Exit(0);
        }
    }

    private static void CheckMaxGreaterThanMin(int min, int max)
    {
        if (max > min) { }
        else
        {
            Console.WriteLine("\nMin value can not be greater than max value!\nGo away!");
            Environment.Exit(0);
        }
    }
}