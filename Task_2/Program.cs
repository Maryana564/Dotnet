/*******************************************************/
/*            Лабораторна  робота №2                   */
/*         Типи даних і введення-виведення             */
/*        Приклад виконання. Варіант № 20              */
/*******************************************************/
using System;

class Program
{
    static void Main()
    {
        // Оголошення масиву даних про рідини
        string[] names = { "Анілін", "Ртуть", "Кедрове масло" };
        char[] types = { 'Ч', 'Ч', 'М' }; // Ч - чиста речовина, М - масло
        int[] temperatures = { 20, 20, 29 };
        int[] speeds = { 1656, 1451, 1406 }; // Швидкість звуку (м/сек)

        // Збереження початкових кольорів консолі
        var defaultForeground = Console.ForegroundColor;

        // Встановлення кольору таблиці (сірий)
        Console.ForegroundColor = ConsoleColor.Gray;

        // Виведення заголовку таблиці з псевдографікою
        Console.WriteLine("┌─────────────────────────────────────────────────┐");
        Console.WriteLine("│ Швидкість звуку в рідинах                       │");
        Console.WriteLine("├─────────────────────────────────────────────────┤");
        Console.WriteLine("│ Речовина       │ Тип │ Температура │ Швидкість  │");
        Console.WriteLine("│                │     │ (град.С)    │ (м/сек)    │");
        Console.WriteLine("├────────────────┼─────┼─────────────┼────────────┤");

        // Виведення даних з псевдографікою і кольоровим форматуванням
        for (int i = 0; i < names.Length; i++)
        {
            // Текстові дані - світло-синій колір
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("│ {0,-14} ", names[i]);

            // Тип рідини - зелений колір
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("│  {0}  ", types[i]);

            // Температура - жовтий колір
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("│    {0,3}       ", temperatures[i]);

            // Швидкість - червоний колір
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("│   {0,4}     │", speeds[i]);
        }

        // Виведення нижньої частини таблиці з псевдографікою
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("├────────────────┴─────┴─────────────┴────────────┤");
        Console.WriteLine("│ Примітка: Ч – чиста речовина, М – масло          │");
        Console.WriteLine("└─────────────────────────────────────────────────┘");

        // Повернення до початкових кольорів консолі
        Console.ForegroundColor = defaultForeground;
    }
}