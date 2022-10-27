/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
(row ,colum - входные данные)
*/

public static class Program
{
    public static void Main()
    {
        int[,] finalArray = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        PrintArray(finalArray);
        try
        {
            int row = Terms("Enter position for row: ");
            int column = Terms("Enter position for columns: ");
            FindElemntOfArray(row, column, finalArray);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.Write("\nThere is no such number in the array!\n\n" + e);
        }

    }

    private static int Terms(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    private static void PrintArray(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                Console.Write(array[row, column] + " ");
            }
            Console.WriteLine();
        }
    }

    private static void FindElemntOfArray(int rowPosition, int columnPosition, int[,] array)
    {
        if (array[rowPosition, columnPosition] != 0)
        {
            Console.WriteLine($"{rowPosition} {columnPosition} -> {array[rowPosition, columnPosition]}");
        }
    }
}