// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.
// 3,5 -> 243 (три в пятой степени)
// 2,4 -> 16 (два в четвертой степени)

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num1, int num2)
{
    int num = 1;
    for (int i = 1; i <= num2; i++)
    {
        num = num * num1; 
    }
    return num;
}
int exp = Exponentiation(a, b);
if (b > 0) Console.Write(exp);
else Console.Write("Второе число должно быть натуральным.");