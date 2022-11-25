// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
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

void SortedRowsMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }    
    }
}

Console.Write("Введите колличество строк массива: m= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: n= ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(matrix);

Console.WriteLine();

SortedRowsMatrix(matrix);
PrintMatrix(matrix);