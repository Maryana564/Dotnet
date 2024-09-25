using System;

class Program
{
    static void Main()
    {
        float x, y;

        // Введення координат
        Console.Write("Введiть координату x: ");
        x = float.Parse(Console.ReadLine());

        Console.Write("Введiть координату y: ");
        y = float.Parse(Console.ReadLine());

        // Перевірка для першої чверті
        if (x >= 0 && x <= 1 && y >= 0 && y <= 1 - x)
        {
            Console.WriteLine("true");
        }
        // Перевірка для третьої чверті
        else if (x <= 0 && x >= -1 && y <= 0 && y >= -1 - x)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}