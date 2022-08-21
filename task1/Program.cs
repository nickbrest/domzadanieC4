// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double b1 = 10;
double k1 = 7;
double b2 = 2;
double k2 = 6;

if (k1 == k2) Console.WriteLine("Прямые параллельны или совпадают");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения прямых имеет координаты: X {x} и Y {y}");
}