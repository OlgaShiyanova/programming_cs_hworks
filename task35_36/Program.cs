// задача35: Одномерный массив 
//  123 случайных чисел. Найдите
// количество элементов массива,
// значения котрых лежит в отрезке [10,99]
// пример для массива из 5, а не 123 элементов.
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 21, 13, 16, 12] -> 5

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

int CountTwoDigitNumber(int[] arr, int min, int max) //конец и начало отрезка в котром числа
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max) count++; // применяем параметры
    }
    return count;
}

int[] array = CreateArrayRndInt(5, 0, 100); //с параметрами 
PrintArray(array);
int countResult = CountTwoDigitNumber(array, 10, 99);
Console.WriteLine($"Количество элементов в диапазоне [10, 99] = {countResult}");