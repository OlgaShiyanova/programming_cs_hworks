﻿// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента 
// в двумерном массиве, и 
// возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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
         Console.Write("! ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine(" !");
    }
}

void FindNumber(int[,] matrix, int number)
{
    int exists = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == number)
            {
                exists = exists + 1;
            }
        }
    }
    if (exists > 0)
            {
                Console.WriteLine($"{number} - присутсвует");
            }
            else Console.WriteLine($"числа {number} нет");
}


int[,] array2d = CreateMatrixRndInt(3, 4, -99, 99);
PrintMatrix(array2d);
Console.WriteLine("Введите число для проверки");
int findNumber = Convert.ToInt32(Console.ReadLine());
FindNumber(array2d, findNumber);