// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

Console.Write("Введите натуральное число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2) GapNumberSum(num1, num2, 0);
else GapNumberSum(num2, num1, 0);
