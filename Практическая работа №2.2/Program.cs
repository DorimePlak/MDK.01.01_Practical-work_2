using System;
namespace ConsoleApplication2
{
    class Program_16
    {
        static void Main()
        {
            Console.Write("Введите количество этажей в небаскребе: ");
            int floor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write($"Наберите номер квартиры " +
                $"(максимальная квартира это {floor * 3}): ");
            int M = Convert.ToInt32(Console.ReadLine());

            int flat = (M - 1) / 3 + 1;
            if (flat % 2 == 0)
            {
                Console.WriteLine($"Лифт остановится на {flat - 1} этаже! Дальше ножками своими до нужного этажа");
                return;
            }
            else Console.WriteLine($"Вы приехали на {flat} этаж!");
        }
    }
} //Задание номер 16