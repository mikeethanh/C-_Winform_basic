using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong phan tu: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(arr);
        Console.WriteLine("Dãy số sau khi sắp xếp tăng dần:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}