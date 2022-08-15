Console.Write("Введите b1: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double b1 = Convert.ToDouble(Console.ReadLine());

void Points(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine($"Пересечение двух прямых находится в точке: ({x};{y})");
}

Points(a, b, a1, b1);