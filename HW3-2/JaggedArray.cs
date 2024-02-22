using System;
namespace HW3_2
{
	public sealed class JaggedArray:BaseArray
	{
        int[][] array;
        public JaggedArray()
        {
            Console.WriteLine("Ступенчатый массив");
            Console.WriteLine("Введите кол-во рядов");
            int rows = int.Parse(Console.ReadLine());

            this.array = new int[rows][];

            for(int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Введите кол-во колонок в {i} ряду");
                int cols = int.Parse(Console.ReadLine());

                this.array[i] = new int[cols];
            }

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

        public override void UserInput()
        {
            Console.WriteLine("Введите значения в массив");


            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    Console.WriteLine($"Введите элементы с индексами {i}, {j}");
                    this.array[i][j] = int.Parse(Console.ReadLine());
                }
            }

        }

        public override void RandomInput()
        {

            Random random = new Random();

            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    this.array[i][j] = random.Next(1, 100);

                }
            }

        }

        public override float Mean()
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    sum += this.array[i][j];
                    count++;

                }
            }

            return sum / count;
        }

        public override void PrintArray()
        {

            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    Console.Write(this.array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}