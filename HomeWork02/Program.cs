// Напишите прогрумму, которая принимает на вход три числа и выдает максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2) max = num2;
    if (max < num3) max = num3;
    Console.Write(max);
    