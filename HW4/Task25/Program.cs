/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Применять Math.Pow нельзя!

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

public static class Program
{
    public static void Main()
    {
        CustomPowForNumber();
    }

    private static int CustomPowForNumber()
    {
        int numberA = Terms("Input number A");
        int numberB = Terms("Input number B - natural pow of A");
        int resultPow = 1;

        for (int i = 1; i <= numberB; i++)
        {
            resultPow *= numberA;
        }
        Console.WriteLine($"{numberA} in pow of {numberB} -> {resultPow}");
        return resultPow;
    }

    private static int Terms(string message)
    {
        Console.WriteLine(message);
        int value = int.Parse(Console.ReadLine());
        return value;
    }
}
