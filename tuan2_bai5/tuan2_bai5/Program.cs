using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so phan tu trong day: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(arr);
        Console.WriteLine("Day so sau khi sap xep tang dan:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}