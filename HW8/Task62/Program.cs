/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

public static class Program
{
    private static int rows = 4;
    private static int columns = 4;
    private static int startNumberIntoArray = 1;
    public static void Main()
    {
        int[,] finalArray = new int[rows, columns];
        FillingPerimeterOfArrayClockwise(finalArray);
        FillingArray(finalArray);
    }

    private static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] / 10 <= 0)
                {
                    Console.Write($" {array[i, j]} ");
                }
            }
            Console.WriteLine();
        }
    }

    private static void FillingPerimeterOfArrayClockwise(int[,] array)
    {
        for (int y = 0; y < columns; y++)
        {
            startNumberIntoArray = array[0, y];
            startNumberIntoArray++;
        }
        for (int x = 1; x < rows; x++)
        {
            startNumberIntoArray = array[x, columns - 1];
            startNumberIntoArray++;
        }
        for (int y = columns - 2; y >= 0; y--)
        {
            startNumberIntoArray = array[rows - 1, y];
            startNumberIntoArray++;
        }
        for (int x = rows - 2; x > 0; x--)
        {
            startNumberIntoArray = array[x, 0];
            startNumberIntoArray++;
        }
        Console.WriteLine("Perimeter was fill:");
        PrintArray(array);
    }

    private static void FillingArray(int[,] array)
    {
        int row = 0;
        int column = 0;
        int multiplication = array.GetLength(0) * array.GetLength(1);
        for (int v = startNumberIntoArray; v <= multiplication; v++)
        {
            startNumberIntoArray = array[row, column];
            v++;
            row++;
            column++;
        }
        Console.WriteLine("\nArray was fill:");
        PrintArray(array); //Не работает, всегда заполняется только 0
    }
}