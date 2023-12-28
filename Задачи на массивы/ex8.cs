ёusing System;

class Program
{
    static void Main()
    {
        // Ввод с клавиатуры количество элементов массива
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());

        // Ввод с клавиатуры элементов массива
        int[] array = ReadArray(n);

        // Вывод массива
        Console.WriteLine("Массив:");
        PrintArray(array);

        // Создание и ввод ступенчатого массива
        int[][] stupArray = InputArray();

        // Вывод ступенчатого массива
        Console.WriteLine("Ступенчатый массив:");
        PrintStupArray(stupArray);
    }

    public static int[] ReadArray(int n)
    {
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите элемент массива: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    public static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static int[][] InputArray()
    {
        // Ввод с клавиатуры количество строк ступенчатого массива
        Console.Write("Введите количество строк ступенчатого массива: ");
        int rows = int.Parse(Console.ReadLine());

        int[][] stupArray = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Введите количество элементов в строке {i + 1}: ");
            int cols = int.Parse(Console.ReadLine());

            stupArray[i] = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Введите элемент ступенчатого массива [{i}][{j}]: ");
                stupArray[i][j] = int.Parse(Console.ReadLine());
            }
        }

        return stupArray;
    }

    public static void PrintStupArray(int[][] stupArray)
    {
        for (int i = 0; i < stupArray.Length; i++)
        {
            for (int j = 0; j < stupArray[i].Length; j++)
            {
                Console.Write(stupArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}