/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
public static class Program
{
    public static void Main()
    {
        try{
             Console.WriteLine("Input first number");
             int firstNumber = int.Parse(Console.ReadLine());
            
             Console.WriteLine("Input second number");
             int secondNumber = int.Parse(Console.ReadLine());
             
             if(firstNumber > secondNumber){
                Console.WriteLine($"First number {firstNumber} bigger than second number {secondNumber}");
                } else if(firstNumber < secondNumber){
                    Console.WriteLine($"Second number {secondNumber} bigger than  first number {firstNumber}");
                    } else {
                        Console.WriteLine($"Maybe first number {firstNumber} = {secondNumber} =)");
                        }
                    } catch (FormatException e){
                        Console.WriteLine("Oh NO! I don't know how use it!\n" + e);
                    }
    }
}                            
                                    
