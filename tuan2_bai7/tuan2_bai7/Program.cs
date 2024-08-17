using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so luong phan tu trong day : ");
        int N = Convert.ToInt32(Console.ReadLine());

        double[] arr = new double[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }

        double totalSum = 0;
        foreach (double num in arr)
        {
            totalSum += num;
        }
        Console.WriteLine($"Tong cua day la : {totalSum}");

        double sumInRange = 0;
        foreach (double num in arr)
        {
            if (num >= 0 && num <= 100)
            {
                sumInRange += num;
            }
        }
        Console.WriteLine($"Tong cac phan tu nam trong doan [0, 100] la: {sumInRange}");

        double max = arr[0];
        double min = arr[0];

        foreach (double num in arr)
        {
            if (num > max) max = num;
            if (num < min) min = num;
        }
        Console.WriteLine($"Gia tri lon nhat cua day la : {max}");
        Console.WriteLine($"Gia tri nho nhat cua day la : {min}");

        int countOutOfRange = 0;
        foreach (double num in arr)
        {
            if (num < 0 || num > 100)
            {
                countOutOfRange++;
            }
        }
        Console.WriteLine($"So phan tu nho hon 0 hoac lon hon 100 la : {countOutOfRange}");
    }
}
