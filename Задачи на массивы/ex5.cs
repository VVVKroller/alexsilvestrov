using System;

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
}