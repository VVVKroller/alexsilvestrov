test
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

        // Найти среднее значение
        double average = FindAverage(array);
        Console.WriteLine("Среднее значение: " + average);
    }

    public static double FindAverage(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        double average = (double)sum / array.Length;
        return average;
    }
}