using System;

class Program
{
    static void Main()
    {
        // Запрос у пользователя значений
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите начальное значение X0: ");
        double x0 = double.Parse(Console.ReadLine());

        Console.Write("Введите шаг изменения X: ");
        double h = double.Parse(Console.ReadLine());

        Console.Write("Введите максимальное значение X: ");
        double maxX = double.Parse(Console.ReadLine());

        Console.WriteLine("\n{0,-10} {1,-20} {2,-30}", "X", "Y1(a/x^2)", "Y2(cos(x) + sin(x))");
        Console.WriteLine(new string('=', 60));

        double x = x0;

        while (x <= maxX)
        {
            // Вычисление значений каждой функции
            double y1 = a / (x * x);
            double y2 = Math.Cos(x) + Math.Sin(x);

            // Вывод значений на консоль
            Console.WriteLine("{0,-10:F2} {1,-20:F4} {2,-30:F4}", x, y1, y2);

            // Проверка условие для выхода (например, y1 достигло заданного порога)
            if (y1 < 0.01) // Например, если Y1(X) меньше 0.01
            {
                Console.WriteLine("Пересечена характерная точка Y1 при X = {0:F2}.", x);
                break;
            }

            x += h; // Увеличиваем x на шаг h
        }
    }
}
