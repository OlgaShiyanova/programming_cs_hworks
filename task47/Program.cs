// Задача 46: задайте 2-мерный массив
// размером m х n, заполненый случайными
// вещественными числами.
// m = 3, n = 4.
// 
// 0,1   4     8    19
// 5    -2    4,4   -2
// 77    3,6   8    1

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("! ");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:F1}  ");
        }
        Console.WriteLine(" !");
    }
}

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns]; 
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

double[,] matrix = CreateMatrixRndDouble(3, 4, 1, 100);
PrintArray(matrix);
Console.WriteLine();