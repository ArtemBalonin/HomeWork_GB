// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает
// вторую цифру этого числа. Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления)
// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Первый вариант решения.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 999 || num < 100) 
{
    Console.WriteLine("Ошибка, введите трехзначное число"); 
    return;
}
int result = (num / 10) % 10;

Console.Write(result);

// Второй вариант решения.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string SecondNumber(int number)
{
    return number > 999 || number < 100 ? "Ошибка, введите трехзначное число": $"{(number / 10) % 10}";
}

Console.Write(SecondNumber(number));