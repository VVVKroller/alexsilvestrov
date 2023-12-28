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

        // Удаление элементов больше 100 по модулю
        int[] newArray = RemoveElements(array);

        // Вывод нового массива
        Console.WriteLine("Новый массив:");
        foreach (int num in newArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static int[] RemoveElements(int[] array)
    {
        int[] newArray = new int[array.Length];
        int count = 0;

        foreach (int num in array)
        {
            if (Math.Abs(num) <= 100)
            {
                newArray[count] = num;
                count++;
            }
        }

        Array.Resize(ref newArray, count);
        return newArray;
    }
}