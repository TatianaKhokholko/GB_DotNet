/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

public static class Program
{
    public static void Main()
    {
        int x = Terms("Input length for x\t");
        int y = Terms("Input length for y\t");
        int z = Terms("Input length for z\t");
        int[,,] array3D = new int[x, y, z];
        FillingArray(array3D);
    }

    private static int Terms(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    private static void PrintArray(int[,,] array3D)
    {
        for (int x = 0; x < array3D.GetLength(0); x++)
        {
            for (int y = 0; y < array3D.GetLength(1); y++)
            {
                for (int z = 0; z < array3D.GetLength(2); z++)
                {
                    Console.Write($"{array3D[x, y, z]} ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        PrintArrayWithIndex(array3D);
    }

    private static void PrintArrayWithIndex(int[,,] array3D)
    {
        for (int x = 0; x < array3D.GetLength(0); x++)
        {
            for (int y = 0; y < array3D.GetLength(1); y++)
            {
                for (int z = 0; z < array3D.GetLength(2); z++)
                {
                    Console.Write($"index({z}) = number{array3D[x, y, z]}; ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    private static void FillingArray(int[,,] array3D)
    {
        int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
        int number;
        for (int i = 0; i < temp.GetLength(0); i++)
        {
            temp[i] = new Random().Next(10, 100);
        }
        int count = 0;
        for (int x = 0; x < array3D.GetLength(0); x++)
        {
            for (int y = 0; y < array3D.GetLength(1); y++)
            {
                for (int z = 0; z < array3D.GetLength(2); z++)
                {
                    array3D[x, y, z] = temp[count];
                    count++;
                }
            }
        }
        PrintArray(array3D);
    }
}
