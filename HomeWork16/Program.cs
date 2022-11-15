// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] arr = CreateArrayDouble(5, 0, 10);
PrintArray(arr);

double MinElemArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
    
    }
    return min;
}

double MaxElemArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(max < array[i]) max = array[i];
    
    }
    return max;
}

double DifferenceElemMaxMin(double num1, double num2)
{
    double difference = num2 - num1;
    double diff = Math.Round(difference, 1);
    return diff;
}
double minNumber = MinElemArray(arr);
double maxNumber = MaxElemArray(arr);
Console.WriteLine($"Минимальное значение массива {minNumber}");
Console.WriteLine($"Максимальное значение массива {maxNumber}");
double difference = DifferenceElemMaxMin(minNumber, maxNumber);
Console.Write($"{maxNumber} - {minNumber} = {difference}");