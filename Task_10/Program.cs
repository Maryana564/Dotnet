using System;

class Program
{
    static void Main()
    {
        double x, y; // Абсциса і ордината графіка
        int h;       // Позиція точки на екрані

        // Налаштування кольорів консолі
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("|   x   |      y     |");
        Console.WriteLine("|-------|------------|");
        Console.ForegroundColor = ConsoleColor.White;

        // Внутрішній цикл для одного періоду
        for (x = 0; x <= 4; x += 0.25)
        {
            // 1-й відрізок (спадна лінія)
            if (x < 1) y = 1 - x;
            // 2-й відрізок (нижня частина півкола)
            else if (x <= 3) y = -Math.Sqrt(1 - Math.Pow(x - 2, 2));
            // 3-й відрізок (зростаюча лінія)
            else y = x - 3;

            // Виведення рядка таблиці
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("| {0,5:0.00} | ", x);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0,10:0.0000000} |", y);
            Console.ForegroundColor = ConsoleColor.White;

            // Визначення позиції точки
            h = (int)((y + 2) * 10);  // Перемістили масштаб для кращого відображення

            // Виведення точки графіка з використанням псевдографічних символів
            Console.Write(" ");
            for (int i = 0; i < h; i++)
            {
                if (i % 10 == 0 && h > 0)
                {
                    Console.Write("│");  // Вертикальна лінія для кращого відображення
                }
                else
                {
                    Console.Write(" ");
                }
            }

            // Додаємо псевдографічний символ для графіка
            if (x < 1)
            {
                Console.Write("/");  // Символ для спадної лінії
            }
            else if (x <= 3)
            {
                Console.Write("/");  // Символ для частини півкола
            }
            else
            {
                Console.Write("\\");  // Символ для зростаючої лінії
            }

            Console.WriteLine();
        }

        // Пауза до введення команди оператора
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Натисніть клавішу Enter...");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();
    }
}
