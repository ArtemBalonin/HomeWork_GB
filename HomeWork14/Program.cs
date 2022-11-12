// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int[] arr = CreateArray(10, 100, 1000);
PrintArray(arr);

int EvenNumbers(int[]array)
{
    int evenNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(array[i] % 2 == 0) evenNumber ++;
    }
    return evenNumber;
}

int even = EvenNumbers(arr);
Console.Write(even);