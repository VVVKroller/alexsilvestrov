using System;
namespace HW3_4
{
	static public class RandomGenerator<T>
	{
		static public T RandomValue()
		{
			if (typeof(T) == typeof(int)) return (T)(object) RandomInt();
			if (typeof(T) == typeof(double)) return (T)(object) RandomDouble();
			if (typeof(T) == typeof(bool)) return (T)(object) RandomBool();
			if (typeof(T) == typeof(string)) return (T)(object)RandomString();
			return (T)(object)false;

        }
		static public int RandomInt()
		{
			Random random = new Random();
			return random.Next(1, 1001);
		}
        static public double RandomDouble()
        {
            Random random = new Random();
			return random.NextDouble();
        }
		static public bool RandomBool()
		{
			Random random = new Random();
			return random.Next(2) == 1;
		}
		static public string RandomString()
		{
            Random random = new Random();
			int l = random.Next(2, 11);
			string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			string s = "";
			for(int i = 0; i < l; i++)
			{
				s = s + chars[random.Next(0, chars.Length)];
			}
			return s;

        }
    }
}

