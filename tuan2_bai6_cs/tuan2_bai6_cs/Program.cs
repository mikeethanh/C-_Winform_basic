using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so diem: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double totalLength = 0;

        double[] x = new double[n];
        double[] y = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap toa do x cua diem thu {i + 1}: ");
            x[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Nhap toa do y cua diem thu {i + 1}: ");
            y[i] = Convert.ToDouble(Console.ReadLine());

            if (i > 0)
            {
                double length = Math.Sqrt(Math.Pow(x[i] - x[i - 1], 2) + Math.Pow(y[i] - y[i - 1], 2));
                totalLength += length;
            }
        }

        Console.WriteLine($"Do dai duong gap khuc: {totalLength}");
    }
}
