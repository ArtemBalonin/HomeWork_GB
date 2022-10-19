// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные
// числа от 1 до N.
// Пример:
// 10 -> 2,4,6,8,10

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
    Console.WriteLine("Недопустимое число");
else
{
    int count = num / num;
    while (count <= num)
    {
        if (count % 2 ==0) Console.Write($"{count} ");
        count++;
    }
}