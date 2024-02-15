using System;

class Program
{
    static void Main()
    {
        int[][] jaggedArray = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6, 7},
            new int[] {8, 9}
        };

        ModifyArray(jaggedArray);

        PrintArray(jaggedArray);
    }

    static void ModifyArray(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int[] innerArray = array[i];
            for (int j = 0; j < innerArray.Length; j++)
            {
                if (j % 2 == 0)
                {
                    innerArray[j] *= j;  
                }
            }
        }
    }

    static void PrintArray(int[][] array)
    {
        foreach (int[] innerArray in array)
        {
            foreach (int num in innerArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}