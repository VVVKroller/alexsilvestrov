using System;

class Program
{
    static void Main()
    {
        // Ввод с клавиатуры количество строк ступенчатого массива
        Console.Write("Введите количество строк ступенчатого массива: ");
        int n = int.Parse(Console.ReadLine());

        // Создание ступенчатого массива
        int[][] jaggedArray = new int[n][];

        // Ввод с клавиатуры элементов ступенчатого массива
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите количество элементов в строке {i + 1}: ");
            int m = int.Parse(Console.ReadLine());

            jaggedArray[i] = new int[m];

            for (int j = 0; j < m; j++)
            {
                Console.Write($"Введите элемент [{i}, {j}]: ");
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }

        // Вывод ступенчатого массива
        Console.WriteLine("Ступенчатый массив:");
        PrintJaggedArray(jaggedArray);

        // Изменение четных элементов на произведения их индексов
        MultElem(jaggedArray);

        // Вывод измененного ступенчатого массива
        Console.WriteLine("Измененный ступенчатый массив:");
        PrintJaggedArray(jaggedArray);
    }

    public static void PrintJaggedArray(int[][] jaggedArray)
    {
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void MultElem(int[][] jaggedArray)
    {
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                if (jaggedArray[i][j] % 2 == 0)
                {
                    jaggedArray[i][j] = jaggedArray[i][j] * i * j;
                }
            }
        }
    }
}