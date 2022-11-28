// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrix3DRndInt(int rows, int colums, int depth)
{
    int[,,] matrix = new int[rows, colums, depth];
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int d = 0; d < matrix.GetLength(2); d++)
            {
                matrix[i, j, d] = count;
                count++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int d = 0; d < matrix.GetLength(2); d++)
            {
                if (d < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, d],5} |");
                else Console.WriteLine($"{matrix[i, j, d],5} |");
            }


        }
    }
}

void PrintIndex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int d = 0; d < matrix.GetLength(2); d++)
            {
                Console.Write($"{matrix[i, j, d]}({i},{j},{d}) ");
            }
        }
    }
}
Console.Write("Введите кол-во строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение глубины в массиве: ");
int depth = Convert.ToInt32(Console.ReadLine());
int sum = rows * colums * depth + 10;

if (sum <= 100)
{
    int[,,] matrix3D = CreateMatrix3DRndInt(rows, colums, depth);
    PrintMatrix(matrix3D);
    PrintIndex(matrix3D);
}
else Console.WriteLine("Заданный массив больше кол-ва двузначных чисел");