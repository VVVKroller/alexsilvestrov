using System;

class Program
{
    static void Main()
    {
        int[][] jaggedArray = new int[][]
        {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7},
            new int[] {8, 9},
            new int[] {10}
        };

        Console.WriteLine("Jagged Array:");
        PrintArray(jaggedArray);

        double average = CalcAvg(jaggedArray);
        Console.WriteLine($"Average value in the jagged array: {average}");
    }

    public static void PrintArray(int[][] jaggedArray)
    {
        foreach (var innerArray in jaggedArray)
        {
            foreach (var element in innerArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

    public static double CalcAvg(int[][] jaggedArray)
    {
        int sum = 0;
        int count = 0;

        foreach (var innerArray in jaggedArray)
        {
            foreach (var element in innerArray)
            {
                sum += element;
                count++;
            }
        }

        return (double)sum / count;
    }
}