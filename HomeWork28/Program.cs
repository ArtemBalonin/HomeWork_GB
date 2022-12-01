// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29 

int Akkerman(int num1, int num2)
{
    if(num1 == 0) return num2 + 1;
    else if(num1 > 0 && num2 == 0) return Akkerman(num1 - 1, 1);
    return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));
}

void PrintAkkerman(int num)
{
    Console.Write(num);
}

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
if(m >= 0 && n >= 0)
{
    int akkerman = Akkerman(m, n);
    PrintAkkerman(akkerman);
}
else Console.Write($"Введеные числа ({m} и {n}) не могут быть отрицательными");


