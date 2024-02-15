using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = ReadArray(n);

        Console.WriteLine("Список до удаления дубликатов элемент:");
        PrintArray(array);

        array = RemoveDups(array);

        Console.WriteLine("Список после удаления дубликатов элемент:");
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

    public static int[] RemoveDups(int[] array)
    {
        array = array.Distinct().ToArray();
        return array;
    }
}