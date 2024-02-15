using System;

public class Program
{
    public static void PrintArray(int[][] jaggedArray)
    {
        foreach (var innerArray in jaggedArray)
        {
            int sum = 0;
            foreach (var element in innerArray)
            {
                sum += element;
            }
            double average = (double)sum / innerArray.Length;
            Console.WriteLine("Среднее: " + average);
        }
    }

    public static void Main()
    {
        int[][] jaggedArray = new int[][]
        {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7},
            new int[] {8, 9}
        };

        PrintArray(jaggedArray);
    }
}