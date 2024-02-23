using System;
namespace HW3_3
{
    public sealed class MatrixArray : BaseArray, IMatrixArray
    {
        int[,] array;
        public MatrixArray()
        {
            Console.WriteLine("Двумерный массив");
            Console.WriteLine("Введите кол-во рядов");

                int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите кол-во колонок");
            int cols = int.Parse(Console.ReadLine());

            this.array = new int[rows, cols];

            Console.WriteLine("Как вы хотите заполнить массив? 1 - самостоятельно, 2 - случайным образом");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                UserInput();
            }
            else
            {
                RandomInput();
            }
        }

        public override void Print()
        {
            int rows = this.array.GetLength(0);
            int cols = this.array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(this.array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override void UserInput()
        { 
            Console.WriteLine("Введите значения в массив");

            int rows = this.array.GetLength(0);
            int cols = this.array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"Введите элементы с индексами {i}, {j}");
                    this.array[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }

        public override void RandomInput()
        {

            int rows = this.array.GetLength(0);
            int cols = this.array.GetLength(1);

            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                { 
                    this.array[i, j] = random.Next(1, 100);

                }
            }

        }

        public override float Mean()
        {
            int rows = this.array.GetLength(0);
            int cols = this.array.GetLength(1);

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += this.array[i, j];

                }
            }

            return sum / (rows * cols);
        }

        public void ReverseEvenEls()
        {
            Console.WriteLine("Печать четных строк в обратном порядке:");
            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = this.array.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(this.array[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}