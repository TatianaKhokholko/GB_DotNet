/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

public static class Programm
{
    public static void Main()
    {
        int[] arrayFirst = ReadInputValue();
        int[] arraySecond = ReadInputValue();
        double valueLength = CountFormula(arrayFirst, arraySecond);
        Console.WriteLine($"The length for value is {valueLength}");
    }
    private static int[] ReadInputValue()
    {
        int[] values = new int[3];
        values[0] = Terms("Input coordinates for X and press enter");
        values[1] = Terms("Input coordinates for Y and press enter");
        values[2] = Terms("Input coordinates for J and press enter");
        return values;
    }
    private static int Terms(string message)
    {
        Console.WriteLine(message);
        int value = int.Parse(Console.ReadLine());
        return value;
    }

    private static double CountFormula(int[] arrayFirst, int[] arraySecond)
    {
        return Math.Sqrt(Math.Pow((arraySecond[0] - arrayFirst[0]), 2) 
        + Math.Pow((arraySecond[1] - arrayFirst[1]), 2) 
        + Math.Pow((arraySecond[2] - arrayFirst[2]), 2));
    }
}