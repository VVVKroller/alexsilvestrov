
using System;

namespace HW3_3
{
    public sealed class LineArray : BaseArray, ILineArray
    {
        int[] array;
        public LineArray()
        {
            Console.WriteLine("Одномерный массив");
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            this.array = new int[n];


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
            Console.WriteLine("Массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public override void UserInput()
        {
            Console.WriteLine("Введите значения в массив");
            for (int i = 0; i < this.array.Length; i++)
            {
                Console.WriteLine($"Введите элемент с индексом {i}");
                this.array[i] = int.Parse(Console.ReadLine());
            }

        }

        public override void RandomInput()
        {
            Random random = new Random();
            for (int i = 0; i < this.array.Length; i++)
            {
                this.array[i] = random.Next(1, 100);
            }
        }

        public override float Mean()
        {
            int s = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                s += this.array[i];
            }
            return s / this.array.Length;
        }

        public void RemoveElUpper100()
        {
            int[] newArray = new int[this.array.Length];
            int newIndex = 0;

            foreach (int i in this.array)
            {
                if (Math.Abs(i) <= 100)
                {
                    newArray[newIndex] = i;

                    newIndex++;
                }
            }
            Array.Resize(ref newArray, newIndex);
            this.array = newArray;
        }

        public void RemoveDup()
        {
            int[] newArray = new int[this.array.Length];
            int newIndex = 0;

            foreach (int i in this.array)
            {
                if (Array.IndexOf(newArray, i) == -1)
                {
                    newArray[newIndex] = i;

                    newIndex++;
                }
            }

            Array.Resize(ref newArray, newIndex);

            this.array = newArray;
        }

    }
}