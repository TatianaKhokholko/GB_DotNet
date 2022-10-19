/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
public static class Program
{
    public static void Main()
    {
        int[] arrayNumbers = Terms("Input some numbers\t");
        CountNumbersBiggerZero(arrayNumbers);
    }

    private static int[] Terms(string message)
    {
        Console.Write(message);
        string customnumber = Console.ReadLine();
        int[] numbers = customnumber.Split(' ', ',', ';').Select(int.Parse).ToArray();
        return numbers;
    }

    private static void CountNumbersBiggerZero(int[] array)
    {
        int countNumberBiggerZero = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                countNumberBiggerZero++;
            }
            else { }
        }
        Console.Write($"Count = {countNumberBiggerZero}");
    }
}