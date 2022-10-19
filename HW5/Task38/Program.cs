
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

public static class Program
{
    public static void Main()
    {
        int arrayLength = Terms("Input length for array. Will be fill with random real numbers\t");
        double[] array = new double[arrayLength];
        double[] finalArray = FillingArray(array);
        FindDifferenceBetweenMaxMinElementsArray(finalArray);
    }

    private static int Terms(string message)
    {
        Console.Write(message);
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    private static double[] FillingArray(double[] countArrayNumber)
    {
        string separate = ", ";

        Console.Write("The array -> [");
        for (int i = 0; i < countArrayNumber.Length; i++)
        {
            countArrayNumber[i] = new Random().NextDouble() * 100;
            if (i < countArrayNumber.Length - 1)
            {
                Console.Write(countArrayNumber[i] + separate);
            }
            else
            {
                Console.Write(countArrayNumber[i]);
            }
        }
        Console.WriteLine("]");
        return countArrayNumber;
    }

    private static void FindDifferenceBetweenMaxMinElementsArray(double[] finalArray)
    {
        double max = CheckMaxValue(finalArray);
        double min = CheckMinValue(finalArray);
        double resultDifference = max - min;

        Console.Write($"Difference between Max and Min elements = {resultDifference}");
    }

    private static double CheckMaxValue(double[] array)
    {
        double maxValue = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }
        Console.WriteLine($"The max number is {maxValue}");
        return maxValue;
    }

    private static double CheckMinValue(double[] array)
    {
        double minValue = array[0];
        for (int i = 0; i < array.Length; i++){
                if (minValue > array[i])
                {
                    minValue = array[i];
                }
        }

        Console.WriteLine($"The min number is {minValue}");
        return minValue;
    }
}