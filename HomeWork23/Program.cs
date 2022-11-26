// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.WriteLine($"{matrix[i, j],5} |");
        }
    }
}

void SumRowsMatrix(int[,] matr)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        minRow += matr[0, j];
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) sumRow += matr[i, j];
        {
            if (sumRow < minRow)
            {
                minRow = sumRow;
                minSumRow = i;
            }
            sumRow = 0;
        }
    }
    Console.WriteLine($"{minSumRow + 1} строка с наименьшей суммой элементов.");
}


Console.Write("Введите колличество строк массива: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: min = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: max = ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, min, max);
PrintMatrix(matrix);

Console.WriteLine();


SumRowsMatrix(matrix);
PrintMatrix(matrix);

