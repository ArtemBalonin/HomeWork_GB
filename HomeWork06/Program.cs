// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления)
// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99)
{
    Console.Write("третьей цифры нет");
    return;
}

while (number > 1000)
{
    number = number / 10;
}
int result = number % 10;
Console.Write(result);