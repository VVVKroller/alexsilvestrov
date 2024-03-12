using System;
using HW3_4;

class Program
{
    static void Main()
    {
        int count, rows, cols, answer;
        // Общий массив (там будут все виды массивов)
        IPrinter[] arrays = new IPrinter[8];
        // Возможные типы массивов

        // int
        Console.WriteLine($"Введите количество элементов линейного массива (int)");
        count = int.Parse(Console.ReadLine());

        Console.WriteLine($"Вы хотите заполнить массив: 1 - самостоятельно, 2 - случайными значениями");
        answer = int.Parse(Console.ReadLine());

        arrays[0] = new LineArray<int>(count, answer == 1);

        // double
        Console.WriteLine($"Введите количество элементов линейного массива (double)");
        count = int.Parse(Console.ReadLine());

        Console.WriteLine($"Вы хотите заполнить массив: 1 - самостоятельно, 2 - случайными значениями");
        answer = int.Parse(Console.ReadLine());

        arrays[1] = new LineArray<double>(count, answer == 1);

        // boolean
        Console.WriteLine($"Введите количество элементов линейного массива (bool)");
        count = int.Parse(Console.ReadLine());

        Console.WriteLine($"Вы хотите заполнить массив: 1 - самостоятельно, 2 - случайными значениями");
        answer = int.Parse(Console.ReadLine());

        arrays[2] = new LineArray<bool>(count, answer == 1);

        //string
        Console.WriteLine($"Введите количество элементов линейного массива (string)");
        count = int.Parse(Console.ReadLine());

        Console.WriteLine($"Вы хотите заполнить массив: 1 - самостоятельно, 2 - случайными значениями");
        answer = int.Parse(Console.ReadLine());

        arrays[3] = new LineArray<string>(count, answer == 1);
        // Создание двумерных массивов всех типов

        // int
        Console.WriteLine($"Введите количество рядов двумерного массива (int)");
        rows = int.Parse(Console.ReadLine());

        Console.WriteLine($"Введите количество столбцов двумерного массива (int)");
        cols = int.Parse(Console.ReadLine());

        Console.WriteLine($"Вы хотите заполнить массив: 1 - самостоятельно, 2 - случайными значениями");
        answer = int.Parse(Console.ReadLine());

        arrays[4] = new MatrixArray<int>(rows, cols , answer == 1);


        // double
        Console.WriteLine($"Введите количество рядов двумерного массива (double)");
        rows = int.Parse(Console.ReadLine());

        Console.WriteLine($"Введите количество столбцов двумерного массива (double)");
        cols = int.Parse(Console.ReadLine());

        Console.WriteLine($"Вы хотите заполнить массив: 1 - самостоятельно, 2 - случайными значениями");
        answer = int.Parse(Console.ReadLine());

        arrays[5] = new MatrixArray<double>(rows, cols, answer == 1);

        // boolean
        Console.WriteLine($"Введите количество рядов двумерного массива (bool)");
        rows = int.Parse(Console.ReadLine());

        Console.WriteLine($"Введите количество столбцов двумерного массива (bool)");
        cols = int.Parse(Console.ReadLine());

        Console.WriteLine($"Вы хотите заполнить массив: 1 - самостоятельно, 2 - случайными значениями");
        answer = int.Parse(Console.ReadLine());

        arrays[6] = new MatrixArray<bool>(rows, cols, answer == 1);

        //string
        Console.WriteLine($"Введите количество рядов двумерного массива (string)");
        rows = int.Parse(Console.ReadLine());

        Console.WriteLine($"Введите количество столбцов двумерного массива (string)");
        cols = int.Parse(Console.ReadLine());

        Console.WriteLine($"Вы хотите заполнить массив: 1 - самостоятельно, 2 - случайными значениями");
        answer = int.Parse(Console.ReadLine());

        arrays[7] = new MatrixArray<string>(rows, cols, answer == 1);


        for (int i = 0; i < arrays.Length; i++)
        {
            arrays[i].Print();
        }
    }
}