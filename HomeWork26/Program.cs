// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumber(int number)
{
    if(number == 0) return;
    if(number == 1)
    {
        Console.Write($"{number}");
        Console.Write('"');
    }
    else
    {
        Console.Write($"{number}, ");
    }
    NaturalNumber(number - 1);
}

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write('"');
NaturalNumber(num);
// Console.Write('"');