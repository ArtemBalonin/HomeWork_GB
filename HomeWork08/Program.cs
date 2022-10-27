// Напишите программу, которая принимает на вход пятизначное число и проверяет
// является ли оно палиндромом (зеракальное ли оно 1234321)
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string Palindrome(int num)
{
    if(num >= 10000 && num <= 99999)
    {
        int num1 = num / 10000;
        int num2 = (num / 1000) % 10;
        int num4 = (num / 10) % 10;
        int num5 = num % 10;
        return num1 == num5 && num2 == num4 ? "да" : "нет";  
    }
    else
    {
        return "Число должно быть пятизначным";
    }
}
string palindrome = (Palindrome(num));
Console.Write(palindrome);