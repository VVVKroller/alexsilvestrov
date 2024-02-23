using System;
namespace HW3_3
{
	class Program
	{
		static void Main()
		{
			IBaseArray[] arrays = new IBaseArray[3];


			arrays[0] = new LineArray();

			arrays[1] = new MatrixArray();

			arrays[2] = new JaggedArray();

			for (int i = 0; i < arrays.Length; i++)
			{
				arrays[i].Print();

				Console.WriteLine($"Среднее - {arrays[i].Mean()}");

			}

			Printer weekdays = new Printer();

			IPrinter[] printable = new IPrinter[4]; //Все массивы + weekdays

			printable[0] = arrays[0];

			printable[1] = arrays[1];

			printable[2] = arrays[2];

			printable[3] = weekdays;

            for (int i = 0; i < printable.Length; i++)
            {
                printable[i].Print();

            }
        }
	}
}

