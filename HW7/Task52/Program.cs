/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
(Округление до 2х знаков - Math.Round(value, 2))
*/

public static class Program
{
    public static void Main()
    {
        int[,] finalArray = {
             { 1, 4, 7, 2 },
             { 5, 9, 2, 3 },
             { 8, 4, 2, 4 }
            };
        PrintArray(finalArray);
        FindAverageForColumns(finalArray);
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

    private static void FindAverageForColumns(int[,] array)
    {
        double sum = 0;
        int column = 0;

        for (int i = 0; i < 3; i++)
        {
            sum += array[i, column];
        }
        Console.Write($"\nThe sum by column = {sum}");
        double average = Math.Round(sum/3, 2);
        Console.Write($"\nThe sum by column = {average}");

        // TO DO I don't know how used all columns =(
    }
}