/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();

Console.WriteLine("Прямая 1. Введите k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Прямая 1. Введите b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Прямая 2. Введите k2");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Прямая 2. Введите b2");
double b2 = double.Parse(Console.ReadLine());

void CoordinatePointLine(double k1, double k2, double b1, double b2)
{
    Console.Write("Уравнение пересечения прямых:\ny = k1 * x + b1\ny = k2 * x + b1\n\n");
    if (k1 != k2)
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k1 * x + b1;
        // double y2 = k2 * x + b2;                 //y2 == y1
        Console.Write($"x = {x} y1 = {y}");
    }
    else if (k1 == k2 && b1 != b2)
    {
        Console.Write("Две прямые параллельны, a значит, они никогда не пересекутся и система не будет иметь решений");

    }
    else if (k1 == k2 && b1 == b2)
    {
        Console.Write("Две прямые совпали, каждая точка будет решением, а у системы будет бесчисленное множество решений.");
    }
}

CoordinatePointLine(k1, k2, b1, b2);