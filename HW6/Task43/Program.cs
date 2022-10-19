/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
------
x=(b2-b1)/(k1-k2)
------
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

public static class Program
{
    public static void Main()
    {
        double b1 = Terms("Input value for b1\t");
        double b2 = Terms("Input value for b2\t");

        double k1 = Terms("Input value for k1\t");
        double k2 = Terms("Input value for k2\t");

        double x = FindXValue(b1, k1, b2, k2);
        FindsPointIntersectionOfTwoLines(b1, k1, b2, k2, x);

    }

    private static double Terms(string message)
    {
        Console.Write(message);
        double number = double.Parse(Console.ReadLine());
        return number;
    }

    private static double FindXValue(double b1, double k1, double b2, double k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        Console.WriteLine($"x = {x}");
        return x;
    }

    private static void FindsPointIntersectionOfTwoLines(double b1, double k1, double b2, double k2, double x)
    {
        double y1 = k1 * x + b1;
        double y2 = k2 * x + b2;
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({y1}; {y2})");
    }
}