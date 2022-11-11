// Напишите программу, которая задает массив из 8 элементов,
// заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

int[] CreateArray(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();  // Вынесли рандом из цикла, так как на мощном компьютере формируются
                                // одинаковые числа!!!
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(-1000, 1000);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length -1) Console.Write(",");
    }
    Console.WriteLine("]");

}
Console.Write("Введите колличество элементов: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
PrintArray(array);