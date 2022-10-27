// Напишите программу, которая на вход принимает число (N) 
// и выдает таблицу кубов чисел от 1 до (N).
// 3 -> 1, 8, 27

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void TableCube(int number)
{
    if (number > 0)
    {
        int index = 1;
        while (index <= number)
        {
            Console.WriteLine($"{index, 4}  {Math.Pow(index, 3)}");
            index ++;
        }
    }
    else Console.WriteLine("Некорректное число");
}
TableCube(num);