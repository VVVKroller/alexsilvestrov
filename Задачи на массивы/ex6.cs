using System;

class Program
{
    static void Main()
    {
        // Ввод с клавиатуры количество строк и столбцов массива
        Console.Write("Введите количество строк массива: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов массива: ");
        int cols = int.Parse(Console.ReadLine());

        // Ввод с клавиатуры элементов массива
        int[,] array = ReadArray(rows, cols);

        // Вывод массива
        Console.WriteLine("Массив:");
        PrintArray(array);
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
}