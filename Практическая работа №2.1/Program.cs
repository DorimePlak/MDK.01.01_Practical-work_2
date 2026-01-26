using System;
namespace ConsoleApplication1
{
    class Program_4
    {
        static void Main()
        {
            Console.Write("Введите х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            if (x > 3) result = -3 * x + 9;
            else result = Math.Pow(x, 3) / (Math.Pow(x, 2) + 8);

            Console.WriteLine($"При х = {x}");
            Console.Write($"Результат = {result}");
        }
    }
} //Задание номер 4