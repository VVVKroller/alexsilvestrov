using System;
namespace HW3_2
{
	class Program
	{
		static void Main()
		{
			BaseArray[] arrays = new BaseArray[3];


			arrays[0] = new LineArray();

			arrays[1] = new MatrixArray();

			arrays[2] = new JaggedArray();

			for (int i = 0; i < arrays.Length; i++)
			{
				arrays[i].PrintArray();

				Console.WriteLine($"Среднее - {arrays[i].Mean()}");

			}
		}
	}
}

