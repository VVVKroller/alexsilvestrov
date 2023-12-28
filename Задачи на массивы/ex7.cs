using System;

class Program
{
    static void Main()
    {
        // Ввод с клавиатуры количество элементов массива
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());

        // Ввод с клавиатуры элементов массива
        int[,] array = ReadArray(n);

        // Вывод массива
        Console.WriteLine("Массив:");
        PrintArray(array);

        // Функция заполняет матрицу по заданной схеме
        int[,] matrix = FillMatrix();

        // Вывод матрицы
        Console.WriteLine("Матрица:");
        PrintMatrix(matrix);
    }

    public static int[,] ReadArray(int n)
    {
        int[,] array = new int[n, 1];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите элемент массива: ");
            array[i, 0] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    public static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            Console.Write(array[i, 0] + " ");
        }
        Console.WriteLine();
    }

    public static int[,] FillMatrix()
    {
        int[,] matrix = new int[3, 3]
        {
            { 1, 2, 3 },
            { 6, 5, 4 },
            { 7, 8, 9 }
        };

        return matrix;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}