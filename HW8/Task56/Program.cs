/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

public static class Program
{
    public static void Main()
    {
        int[,] finalArray = {
             { 1, 4, 7, 2},
             { 5, 9, 2, 3},
             { 8, 4, 2, 4},
             { 5, 2, 6, 7}
            };
        Console.WriteLine("Default array:");
        PrintArray(finalArray);
        CountSumForLinesAndPrint(finalArray);

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

    private static void CountSumForLinesAndPrint(int[,] array)
    {
        int minSum = 0;
        int sumForLine = array[0, 0];
        for (int i = 1; i < array.GetLength(1); i++)
        {
            sumForLine += array[0, i];
        }

        for (int j = 1; j < array.GetLength(0); j++)
        {
            int temp = array[1, 0];
            for (int k = 1; k < array.GetLength(1); k++)
            {
                temp += array[k, k];
            }
            if (sumForLine > temp)
            {
                sumForLine = temp;
                minSum = j;
            }
        }
        Console.WriteLine($"\n{minSum + 1} - the line with min sum = {sumForLine}\n");
    }
}