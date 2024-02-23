
using System;
namespace HW3_3
{
	public class Printer:IPrinter
	{
		public void Print()
		{
            string[] weekdays = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

			for (int i = 0; i < weekdays.Length; i++)
			{
				Console.Write($"{weekdays[i]} ");
			}
		}
	}
}

