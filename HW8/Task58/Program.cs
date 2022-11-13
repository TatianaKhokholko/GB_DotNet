/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18
*/
using System;

public static class Program
{
    public static void Main()
    {
        int[,] firstArray = {
             { 2, 4},
             { 3, 2}
            };
        Console.WriteLine("First array:");
        PrintArray(firstArray);

        int[,] secondArray = {
             { 3, 4},
             { 3, 3}
            };
        Console.WriteLine("Second array:");
        PrintArray(secondArray);

        var result = ArrayMultiplication(firstArray, secondArray);
        Console.WriteLine("The result after multiply arrays:");
        PrintArray(result);
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
        Console.WriteLine();
    }

    private static int[,] ArrayMultiplication(int[,] array1, int[,] array2)
    {
        int rowsFirstArray = array1.GetUpperBound(0) + 1;
        int rowsSecondArray = array2.GetUpperBound(0) + 1;

        int columnsFirstArray = array1.GetUpperBound(1) + 1;
        int columnsSecondArray = array2.GetUpperBound(1) + 1;
        CheckFieldAndColumnMatching(rowsSecondArray, columnsFirstArray);

        var temp = new int[rowsFirstArray, columnsSecondArray];
        for (int i = 0; i < rowsFirstArray; i++)
        {
            for (var j = 0; j < columnsSecondArray; j++)
            {
                temp[i, j] = 0;
                for (int k = 0; k < columnsFirstArray; k++)
                {
                    temp[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
        return temp;
    }

    private static void CheckFieldAndColumnMatching(int linesSecondArray, int columnsFirstArray)
    {
        if (linesSecondArray != columnsFirstArray)
        {
            throw new Exception("The number of columns of the 1 array isn't equals to the number of rows of the 2 array.");
        }
    }
}