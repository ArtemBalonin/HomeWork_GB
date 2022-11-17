// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Для проверки самого себя добавил еще 1 пример: 
// b1 = 3, k1 = 5, b2 = 1, k2 = 6 -> (13, 2)

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double CoordinatePointY(double b1, double k1, double b2, double k2)
{
    double resultY = 0;
    resultY = (((-k2 * b1) / k1) + b2) / (1 - ((k2 * 1) / k1));
    double resY = Math.Round(resultY, 1);
    return resY;
}

double CoordinatePointX(double numY)
{
    double numX = (numY - b1) / k1;
    double numberX = Math.Round(numX, 1);
    return numberX;
}

void Coordinates(double x, double y)
{
    if(x != 0 && y != 0) Console.WriteLine($"Координаты точки пересечения двух прямых: x = {x} y = {y}");
    else Console.WriteLine("По заданным значения, прямые не пересекаются.");
}

double numY = CoordinatePointY(b1, k1, b2, k2);
Console.WriteLine($"Координата точки Y: {numY}");

double numX = CoordinatePointX(numY);
Console.WriteLine($"Координата точки Х: {numX}");

Coordinates(numX, numY);