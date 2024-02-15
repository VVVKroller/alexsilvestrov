using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());

        int[,] array = ReadArray(n);

        Console.WriteLine("Array:");
        PrintArray(array);

        double average = CalculateAverage(array);
        Console.WriteLine($"Среднее значение: {average}");
    }

    public static int[,] ReadArray(int n)
    {
        Console.WriteLine("Enter the elements of the array:");
        int rows = 1;
        int cols = n;
        int[,] array = new int[rows, cols];

        for (int j = 0; j < n; j++)
        {
            Console.Write($"Введите элемент [{0}][{j}]: ");
            array[0, j] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    public static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static double CalculateAverage(int[,] array)
    {
        int sum = 0;
        int count = 0;

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
                count++;
            }
        }

        return (double)sum / count;
    }
}