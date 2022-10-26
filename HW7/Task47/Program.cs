/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

(Округление до 2х знаков после запятой - Math.Round(value, 2))
*/

public static class Program
{
    public static void Main()
    {
        int m = Terms("Enter the count strings:\t");
        int n = Terms("Enter the count columns:\t");
        int[,] array = CreateArray(m, n);
        PrintArray(array);
    }

    private static int Terms(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    private static int[,] CreateArray(int countRows, int countColumns)
    {
        int[, ] createdArray = new int[countRows, countColumns];
        for (int row = 0; row < countRows; row++)
        {
            for (int column = 0; column < countColumns; column++)
            {
                createdArray[row, column] = new Random().Next(-10, 10);
            }
        }
        return createdArray;
    }

    private static void PrintArray(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                Console.Write(String.Format("{0,4}", array[row, column]));
            }
            Console.WriteLine();
        }
    }

}