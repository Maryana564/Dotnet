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

        // Перевірка умов для першої і третьої чверті
        bool inFirstQuadrant = x >= 0 && x <= 1 && y >= 0 && y <= 1 - x;
        bool inThirdQuadrant = x <= 0 && x >= -1 && y <= 0 && y >= -1 - x;

        // Вивід результату за допомогою тернарного оператора
        Console.WriteLine((inFirstQuadrant || inThirdQuadrant) ? "true" : "false");
    }
}