﻿// Задача 44:
// не используя рекурсию, вывести
// первые N чисел Фибоначчи.
// Первые два числа 0 и 1.
// Если N = 5, то 0 1 1 2 3 
// Если N = 3, то 0 1 1
// Если N = 7, то 0 1 1 2 3 5 8

int[] FibArray(int num)
{
    int[] array = new int[num];
    // array[0]=0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i] },");
        else Console.Write($"{arr[i]}"); //округление до 1 знака
    }
    Console.WriteLine("]");
}

Console.WriteLine("введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] resultArray = FibArray(number);
PrintArray(resultArray);
