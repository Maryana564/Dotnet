/**************************************************/
/*            Лабораторна робота №3               */
/*   Арифметичні операції та математичні функції  */
/*                  мови C#                       */
/*         Приклад вирішення. Варіант №20.        */
/**************************************************/
using System;

class Program
{
    static void Main()
    {
        // Вхідні параметри, які вводяться користувачем
        double x = 0, y = 0;

        // Параметри, значення яких задаються в програмі
        double a = 12.5;
        double m = 1.3;
        double n = 14.1;

        // Параметри, значення яких обчислюються
        double t1 = 0, t2 = 0;

        try
        {
            // Введення значень x і y
            Console.Write("Введіть x, y > ");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            // Перевірка вхідних даних на коректність
            if (Math.Pow(a, 2) - Math.Pow(x, 2) == 0)
                throw new DivideByZeroException("Помилка: знаменник виразу містить нуль.");

            if (Math.Pow(a, 2) + Math.Pow(x, 2) < 0)
                throw new ArithmeticException("Помилка: від'ємне значення під логарифмом.");

            // Обчислення t1 за формулою: t1 = 1/4a^3 * ln((a^2 + x^2) / (a^2 - x^2))
            t1 = (1 / (4 * Math.Pow(a, 3))) * Math.Log((Math.Pow(a, 2) + Math.Pow(x, 2)) / (Math.Pow(a, 2) - Math.Pow(x, 2)));

            // Перевірка аргументів для тригонометричних функцій
            double ax = a * x;
            if (Math.Sin(ax) == 0)
                throw new DivideByZeroException("Помилка: синус в знаменнику дорівнює нулю.");

            // Обчислення t2 за формулою: t2 = cos^(n-1)(ax) / (a(m-1) * sin^(m-1)(ax))
            t2 = Math.Pow(Math.Cos(ax), n - 1) / (a * (m - 1) * Math.Pow(Math.Sin(ax), m - 1));


            Console.WriteLine($"t1 = {t1}");
            Console.WriteLine($"t2 = {t2}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка: введено некоректне значення. Переконайтеся, що ви ввели числа.");
        }
        finally
        {
            Console.WriteLine("Обчислення завершено.");
        }
    }
}