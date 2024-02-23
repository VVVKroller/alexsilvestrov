using System;
namespace HW3_3
{
	public abstract class BaseArray:IBaseArray
	{
		public BaseArray()
		{
		}
		abstract public void Print();

		abstract public void UserInput();

		abstract public float Mean();

		abstract public void RandomInput();
	}
}

