using System;

class Program
{
    static void Main()
    {
        // Введення параметрів
        Console.Write("Введiть межу похибки (eps): ");
        double eps = double.Parse(Console.ReadLine());

        Console.Write("Введiть кількість членів ряду для обчислення: ");
        int maxTerms = int.Parse(Console.ReadLine());

        long n = 0;              // Параметр ряду
        double sum = 0;         // Сума членів ряду
        double term;            // Значення поточного члена
        int k1 = 1;             // pow(-1, n)
        int termsProcessed = 0; // Кількість оброблених членів ряду

        // Основний цикл
        while (termsProcessed < maxTerms)
        {
            // Обчислення чергового члена ряду
            term = k1 * (n - 1.0) / (2 * n * n + 1.0);

            // Перевірка досягнення межі точності
            if (Math.Abs(term) >= eps)
            {
                // Якщо межа точності не досягнута - накопичення суми
                sum += term;
            }
            else
            {
                // Якщо межа точності досягнута - вихід з циклу
                break;
            }

            // Оновлення параметрів
            n++;
            k1 = -k1;
            termsProcessed++;
        }

        // Виведення результатів
        if (termsProcessed == maxTerms)
        {
            Console.WriteLine($"Сума {maxTerms} членів ряду = {sum:F7}");
        }
        else
        {
            Console.WriteLine($"Сума досягнута при досягненні заданої похибки = {sum:F7}");
        }
    }
}
