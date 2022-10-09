/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

public static class Programm
{
    public static void Main()
    {
        Console.WriteLine("Input input number indicating the day of the week (range from 1 to 7)");
        int inputNumberWeek = int.Parse(Console.ReadLine());

        switch (inputNumberWeek)
        {
            case 1:
                Console.WriteLine("Monday - works day");
                break;
            case 2:
                Console.WriteLine("Tuesday - works day");
                break;
            case 3:
                Console.WriteLine("Wednesday - works day");
                break;
            case 4:
                Console.WriteLine("Thursday - works day");
                break;
            case 5:
                Console.WriteLine("Friday - works day");
                break;
            case 6:
                Console.WriteLine("Saturday - yes it's day off");
                break;
            case 7:
                Console.WriteLine("Sunday - yes it's day off");
                break;

            default:
                Console.WriteLine("Value out of range!");
                break;
        }
    }
}