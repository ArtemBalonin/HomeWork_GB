// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10

// Решение с помощью цикла for

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = 0;
    for (int i = 0; i < num | i > num;)
    {
        sum = num % 10 + sum;
        num = num / 10;
    }
    return sum;
}

int sumDigits = SumDigits(number);
Console.Write(sumDigits);

// Решение с помощью цикла while

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = 0;
    while (0 < num | 0 > num)
    {
        sum = num % 10 + sum;
        num = num / 10;
    }
    return sum;
}
int sumDigits = SumDigits(number);
Console.Write(sumDigits);