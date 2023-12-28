using System;

class Program
{
    static void Main()
    {
        // Ввод с клавиатуры количество строк и столбцов двумерного массива
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        // Ввод с клавиатуры элементов двумерного массива
        int[,] array = ReadArray(rows, columns);

        // Вывод двумерного массива
        Console.WriteLine("Массив:");
        PrintArray(array);
    }

    public static int[,] ReadArray(int rows, int columns)
    {
        int[,] array = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введите элемент массива [{i}, {j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return array;
    }

    public static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}