/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Input one number");
        int inputNumber = int.Parse(Console.ReadLine());

        if(inputNumber%2 != 0){
            Console.WriteLine($"Number {inputNumber} is NOT even");
        } else
        Console.WriteLine($"Number {inputNumber} is even");
    }
}