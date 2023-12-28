using System;

class Program
{
    static void Main()
    {
        // Ввод с клавиатуры количество строк ступенчатого массива
        Console.Write("Введите количество строк ступенчатого массива: ");
        int rows = int.Parse(Console.ReadLine());

        // Ввод с клавиатуры элементов ступенчатого массива
        int[][] array = ReadArray(rows);

        // Вывод ступенчатого массива
        Console.WriteLine("Массив:");
        PrintArray(array);
    }

    public static int[][] ReadArray(int rows)
    {
        int[][] array = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Введите количество элементов в строке {i + 1}: ");
            int elements = int.Parse(Console.ReadLine());

            array[i] = new int[elements];

            for (int j = 0; j < elements; j++)
            {
                Console.Write($"Введите элемент массива [{i}, {j}]: ");
                array[i][j] = int.Parse(Console.ReadLine());
            }
        }

        return array;
    }

    public static void PrintArray(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("[");

            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j]);

                if (j < array[i].Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
        }
    }
}