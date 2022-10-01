/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Input some numbers");
        int numbers = int.Parse(Console.ReadLine());
        
        Console.Write($"{numbers}-> ");
        string splitChar = ", ";
        for (int i = 1; i <= numbers; i++){
            if(i%2==0){       
                Console.Write(i+splitChar);
            }
        }
    }
}
