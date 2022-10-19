// Напишите программу, которая на вход принимает два числа и выдает,
// какое число больше, а какое меньше.
// Например:
// a = 5, b = 7 -> max = 7

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) Console.Write($"{a} больше, {b} меньше");
else if (a < b) Console.Write($"{a} меньше, {b} больше");
else Console.Write("Числа равны");