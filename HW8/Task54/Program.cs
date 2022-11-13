/* 
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

public static class Program
{
    public static void Main()
    {
        int[,] finalArray = {
             { 1, 4, 7, 2},
             { 5, 9, 2, 3 },
             { 8, 4, 2, 4 }
            };
        PrintArray(finalArray);
        SortInDescendingOrder(finalArray);
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

    private static void SortInDescendingOrder(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int fordesc = 0; fordesc < array.GetLength(1) - 1; fordesc++)
                {
                    if (array[i, fordesc] < array[i, fordesc + 1])
                    {
                        int descArrayResult = array[i, fordesc + 1];
                        array[i, fordesc + 1] = array[i, fordesc];
                        descArrayResult = array[i, fordesc];
                    }
                }
            }
        }
        Console.WriteLine();
        PrintArray(array);
    }
}
