// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

Console.WriteLine("Сколько чисел вы будете вводить? Введите количество: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int[] UserInputNumbers(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
}

int[] arr = UserInputNumbers(quantity);
PrintArray(arr);

int QuantityNumMoreZero(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) result ++;
    }
    return result;
}

int res = QuantityNumMoreZero(arr);
Console.Write(res);