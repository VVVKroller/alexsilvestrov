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

        // Удаление повторяющихся элементов
        int[] newArray = RemoveDuplicates(array);

        // Вывод обновленного массива
        Console.WriteLine("Обновленный массив:");
        PrintArray(newArray);
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

    public static int[] RemoveDuplicates(int[] array)
    {
        int[] newArray = new int[array.Length];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;

            // Проверяем, есть ли текущий элемент в новом массиве
            for (int j = 0; j < index; j++)
            {
                if (array[i] == newArray[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            // Если элемент не является дубликатом, добавляем его в новый массив
            if (!isDuplicate)
            {
                newArray[index] = array[i];
                index++;
            }
        }

        // Создаем сокращенный массив с уникальными элементами
        int[] resultArray = new int[index];
        Array.Copy(newArray, resultArray, index);

        return resultArray;
    }
}