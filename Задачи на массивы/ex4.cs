using System;

class Program
{
    static void Main()
    {
        // Ввод с клавиатуры размера массива
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());

        // Ввод с клавиатуры элементов массива
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите элемент массива: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Вывод массива
        Console.WriteLine("Массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Создание двумерного массива
        int[,] arrayspisok = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Вывод двумерного массива
        Printarrayspisok(arrayspisok);
    }

    public static void Printarrayspisok(int[,] array)
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