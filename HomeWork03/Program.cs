// Напиши прогрумму, которая на вход принимает число и выдает, является ли число четным
// Делится ли оно без остатка на 2
// Пример:
// 4 -> да
// -3 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.Write("Да");
    else Console.Write("Нет");