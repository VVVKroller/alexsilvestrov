using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк в массиве: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов в массиве: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] array = ReadArray(rows, cols);

        Console.WriteLine("Список до изменений:");
        PrintArray(array);

        Console.WriteLine("Список после изменений:");
        PrintMod(array);
    }

    public static int[,] ReadArray(int rows, int cols)
    {
        int[,] array = new int[rows, cols];
        Console.WriteLine("Введите элементы массива:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Введите элемент массива [{i}][{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
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

    public static void PrintMod(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            if (i % 2 != 0)
            {
                for (int j = cols - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            else
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}