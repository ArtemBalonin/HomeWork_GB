//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 такого элемента в массиве нет.

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
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 5} ");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine(" |");
    }
}

int[,] arr2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(arr2D);

Console.Write("Введите первую позицию элемента: ");
int elem1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую позицию элемента: ");
int elem2 = Convert.ToInt32(Console.ReadLine());


if(elem1 > 3 || elem2 > 4) Console.Write("Такого элемента в массиве нет");
else Console.Write($"По позициям {elem1} и {elem2}, значение элемента будет = {arr2D[elem1,elem2]}");





// ($"По позициям {elem1} и {elem2}, значение элемента будет = {result}");