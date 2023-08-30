﻿// задача 38:
// (найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, паройвторой и предпоследний и т.д.
// результат записать в новом массиве.)
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
// ([1 2 3 4 5] -> 5 8 3)
// ([10, 11, 12, 13, 14] -> 5)

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] PairMultiplication(int[] arr)
{
    int size = arr.Length / 2 + arr.Length % 2;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length-1-i];
    }
    if (arr.Length % 2 == 1) newArr[newArr.Length-1] = arr[arr.Length / 2];
    return newArr;
}

int[] array = CreateArrayRndDouble(5, 1, 100); 
PrintArray(array);
// int[] pairMultiplication = PairMultiplication(array);
// PrintArray(pairMultiplication);