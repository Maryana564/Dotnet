using System;

class Program
{
    static void Main()
    {
     
        double x, y;
     
        double a = 12.5; 
        double m = 1.3;   
        double n = 14.1;
        double t1 = double.NaN, t2 = double.NaN;
        double ax;

        Console.Write("Введіть x > ");
        x = Convert.ToDouble(Console.ReadLine());

        // Обчислення t1 за формулою:
        // t1 = 1 / (4a^3) * ln((a^2 + x^2) / (a^2 - x^2))
        t1 = (1 / (4 * Math.Pow(a, 3))) * Math.Log((Math.Pow(a, 2) + Math.Pow(x, 2)) / (Math.Pow(a, 2) - Math.Pow(x, 2)));

        // Обчислення t2 за формулою:
        // t2 = cos^(n-1)(ax) / (a(m-1) * sin^(m-1)(ax))
        ax = a * x;
        t2 = Math.Pow(Math.Cos(ax), n - 1) / (a * (m - 1) * Math.Pow(Math.Sin(ax), m - 1));

        Console.WriteLine($"t1 = {t1}");
        Console.WriteLine($"t2 = {t2}");
    }
}
