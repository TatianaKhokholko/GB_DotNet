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
        CheckInputValue(numberA);
        int numberB = Terms("Input number B - natural pow of A");
        CheckInputValue(numberB);
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

      private static void CheckInputValue(int number)
    {
        if (number <= 0) {
            Console.WriteLine("Need a number greater than 0!");
            Environment.Exit(0);
         }
        else{}
    }
}
