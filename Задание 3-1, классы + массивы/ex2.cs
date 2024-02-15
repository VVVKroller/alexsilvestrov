using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = ReadArray(n);

        Console.WriteLine("Список до удаления элементов, которые больше 100 по модулю:");
        PrintArray(array);

        array = RemElm(array);

        Console.WriteLine("Список после удаления элементов, которые больше 100 по модулю:");
        PrintArray(array);
    }

    public static int[] ReadArray(int n)
    {
        Console.WriteLine("Введите элементы массива:");
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    public static void PrintArray(int[] array)
    {
        Console.WriteLine("Список:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static int[] RemElm(int[] array)
    {
        array = Array.FindAll(array, element => Math.Abs(element) <= 100);
        return array;
    }
}