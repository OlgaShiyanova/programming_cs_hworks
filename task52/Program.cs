// Задача 52. Задайте двумерный 
// массив из целых чисел. Найдите 
// среднее арифметическое элементов 
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
         Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine(" |");
    }
}

double AverageColumnsElements(int[,] matrix)
{
    int sum = 0;
    int size = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
        for (int i = 0; i < size; i++)
    {
        sum += matrix[i,i];
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(3, 4, -99, 99);
PrintMatrix(array2d);
int sumElementsMainDiagonal = SumElementsMainDiagonal(array2d);
Console.WriteLine($"Сумма элементов = {sumElementsMainDiagonal}");