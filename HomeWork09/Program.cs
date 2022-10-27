// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// А(3,6,8): В(2,1,-7) -> 15.84

// Тиарема Пифагора: A1A2 = квадратный корень(x2 - x1)**2 + (y2 - y1)**2 + (z2 - z1)**2
// C помощью функции Math.Pow возведем в квадрат
// C помощью функции Math.Sqrt извлекаем корень из числа
// С помощью функции Math.Round(переменная, число, т.е сколько знаков после запятой) ->
// мы округлим число
// Чтобы округлить число без автоматизма, нужно добавить 3-ий аргумент.
// MidpointRounding.ToZero

Console.Write("Введите координату точки x1: ");
int x_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки y1: ");
int y_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки z1: ");
int z_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки x2: ");
int x_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки y2: ");
int y_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки z2: ");
int z_2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

double distance = Distance(x_1, x_2, y_1, y_2, z_1, z_2);
double result = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.Write(result);