// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

// Первый вариант решения.

// Console.Write("Введите число: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if(day == 6 || day == 7) Console.Write("да");
// if(day > 0 && day < 6) Console.Write("нет");
// if(day > 7 || day < 1) Console.Write("Такого дня недели не существует");

// Второй вариант решения.

// Console.Write("Введите число: ");
// int day = Convert.ToInt32(Console.ReadLine());

// string Weekend(int day)
// {
//     return day == 6 || day == 7 ? "да" : "нет";
// }
// if(day > 7 || day < 1) Console.Write("Такого дня недели не существует");
// Console.Write(Weekend(day));

// Третий вариант решения.

Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

bool Weekend(int day)
{
    return day == 6 || day ==7;
}
if(day > 7 || day < 1) Console.Write("Такого дня недели не существует");
bool weekend = Weekend(day);
Console.Write(weekend? "да": "нет");