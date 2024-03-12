using System;
namespace HW3_4
{
    sealed public class MatrixArray<T> : BaseArray, ILineArray
    {

        private T[,] array;

        public MatrixArray(int rows, int cols, bool userFill = false)
        {
            array = new T[rows, cols];
            if (userFill)
            {
                UserFill();
            }
            else
            {
                RandomFill();
            }
        }

        private void UserFill()
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            Console.WriteLine("Введите значения массива: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"Введите значение эл-та массива с индексом {i},{j}");
                    array[i, j] = (T)(object)Console.ReadLine();
                }
            }
        }

        private void RandomFill()
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = RandomGenerator<T>.RandomValue();
                }
            }

        }

        public override void Print()
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            Console.Write("[ ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{this.array[i, j]}, ");

                }
                Console.Write(" ]");
                Console.WriteLine();
            }
            Console.WriteLine("]");
        }
    }
}

