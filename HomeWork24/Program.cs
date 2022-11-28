// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplicationFirstSecondMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultMatrix;
}


Console.Write("Введите колличество строк первого массива: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов второго массива: n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов первого массива и количество строк второго массива: p = ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: min = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: max = ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] firstMatrix = CreateMatrixRndInt(m, p, min, max);
Console.WriteLine("Первая матрица: ");
PrintMatrix(firstMatrix);

Console.WriteLine();

int[,] secondMatrix = CreateMatrixRndInt(p, n, min, max);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondMatrix);

Console.WriteLine();

if(m != n)
{
    Console.WriteLine("Произведение матриц невозможно, (m) и (n) должны быть равны.");
}
else
{
    int[,] resultMatrix = MultiplicationFirstSecondMatrix(firstMatrix, secondMatrix);
    PrintMatrix(resultMatrix);
}