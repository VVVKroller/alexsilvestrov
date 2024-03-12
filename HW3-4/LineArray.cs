using System;
namespace HW3_4
{
	sealed public class LineArray<T> : BaseArray, ILineArray
	{

		private T[] array;

		public LineArray(int count, bool userFill = false)
		{
			array = new T[count];
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
			Console.WriteLine("Введите значения массива: ");
			for (int i = 0; i < this.array.Length; i++)
			{
				Console.WriteLine($"Введите значение эл-та массива с индексом {i}");
				array[i] = (T)(object) Console.ReadLine();
			}
		}

		private void RandomFill()
		{
            for (int i = 0; i < array.Length; i++)
			{
				array[i] = RandomGenerator<T>.RandomValue();
			}

        }

		public override void Print()
		{
			Console.Write("[ ");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i]}, ");
			}
            Console.Write(" ]");
			Console.WriteLine();
        }
	}
}

