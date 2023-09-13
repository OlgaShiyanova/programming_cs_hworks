// Задача 62: Напишите программу, которая 
// заполнит спирально массив 4 на 4.
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" 0{array[i,j]}"); //применяем отступ

      else Console.Write($"{array[i,j], 3}"); //применяем форматирование
    }
    Console.WriteLine();
  }
}

int n = 4;
int[,] spiralMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(spiralMatrix);