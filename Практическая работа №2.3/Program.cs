using System;
namespace ConsoleApplication3
{
    class Program_15
    {
        static void Main()
        {
            Console.WriteLine("1) сторона a;");
            Console.WriteLine("2) высота h;");
            Console.WriteLine("3) радиус вписанной окружности r;");
            Console.WriteLine("4) радиус описанной окружности R.");
            Console.WriteLine();

            Console.Write("Введите номер элемента(1-4): ");
            int elementNumber = Convert.ToInt32(Console.ReadLine());
            
            if (elementNumber < 1 || elementNumber > 4)
            {
                    Console.WriteLine("Нет такого номера элемента! ");
                    return;
            }


            Console.Write("Введите значение элемента: ");
            double value = Convert.ToDouble(Console.ReadLine());

            double a = 0, h = 0, r = 0, R = 0;
            switch (elementNumber)
            {
                case 1:
                    a = value;
                    h = (a * Math.Sqrt(3)) / 2;
                    r = (a * Math.Sqrt(3)) / 6;
                    R = (a * Math.Sqrt(3)) / 3;
                    break;
                case 2:
                    h = value;
                    a = (2 * h) / Math.Sqrt(3);
                    r = (a * Math.Sqrt(3)) / 6;
                    R = (a * Math.Sqrt(3)) / 3;
                    break;
                case 3:
                    r = value;
                    a = (6 * h) / Math.Sqrt(3);
                    h = (a * Math.Sqrt(3)) / 2;
                    R = (a * Math.Sqrt(3)) / 3;
                    break;
                case 4:
                    R = value;
                    a = (3 * h) / Math.Sqrt(3);
                    h = (a * Math.Sqrt(3)) / 2;
                    r = (a * Math.Sqrt(3)) / 6;
                    break;
            }

            Console.WriteLine();
            Console.WriteLine($"Сторона треугольника (а): {a:f2}");
            Console.WriteLine($"Высота треугольника (h): {h:f2}");
            Console.WriteLine($"Радиус вписанной окружности (r): {r:f2}");
            Console.WriteLine($"Радиус описанной окружности (R): {R:f2}");
        }
    }
} //Задание номер 15