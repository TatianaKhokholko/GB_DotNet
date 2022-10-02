/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
public static class Program
{
    public static void Main()
    {
        try{
            Console.WriteLine("Input three (or more as you wish!) numbers (example 1,2,3)\n ");
            string? inputValue = Console.ReadLine();
            int[] numbers = inputValue.Split(' ', ',', ';').Select(int.Parse).ToArray();
            
            int maxNumber = 0;
            for (int i = 0; i <= numbers.Length - 1; i++){
                if(maxNumber <= numbers[i]){
                    maxNumber = numbers[i];
                    }
                    }
                    Console.WriteLine("Max number is = " + maxNumber);
                    } catch (FormatException e){
                        Console.WriteLine("What else do you want to input?!\n" + e);
                        }
    }
}