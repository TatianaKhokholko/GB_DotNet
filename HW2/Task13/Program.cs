/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

public static class Programm
{
    public static void Main()
    {
        Console.WriteLine("Input three-digit number and press enter:");
        int inputNumber = int.Parse(Console.ReadLine());

        if (inputNumber >= 100 && inputNumber <= 999)
        {
            while (inputNumber > 100)
            {
                inputNumber %= 100;
            }

            int thirdNumber = inputNumber % 10;
            Console.WriteLine($"The third value is {thirdNumber}");
        }
        else if (inputNumber < 100)
        {
            Console.WriteLine($"The number {inputNumber} is not three-digit. The third value is absent!");
        }
        else
        {
            Console.WriteLine($"The number {inputNumber} is not three-digit\nBut third value is {inputNumber.ToString()[2]}");
        }
    }
}