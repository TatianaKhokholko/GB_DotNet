/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

public static class Programm
{
    public static void Main()
    {
        Console.WriteLine("Input three-digit number and press enter:");
        int inputNumberValue = int.Parse(Console.ReadLine());     

        while (inputNumberValue > 99){
            inputNumberValue /=10;
        }

        int secondNumber = inputNumberValue %10;
        Console.WriteLine("Second number is " + secondNumber);
    }
}