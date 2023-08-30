// задача36: Одномерный массив 
// случайных чисел. Найдите
// сумму элементов массива,
// стоящих на нечетных позициях
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int SumNumbers(int[] arr) 
{
    int sum = 0;
    int i = 0;
    while (i < arr.Length + 1) 
    {
        if (i % 2 == 1)
        {
        sum = sum + arr[i];       
//        if (arr[i] >= min && arr[i] <= max) count++; // применяем параметры
        }
        i++; 
    }
    return sum;
}

// int[] array = CreateArrayRndInt(5, 0, 100); //с параметрами 
int[] array = CreateArrayRndInt(4, 0, 20);
PrintArray(array);
int sumResult = SumNumbers(array);
Console.WriteLine($"сумма нечетных элементов = {sumResult}");
// int countResult = CountTwoDigitNumber(array, 10, 99);
// Console.WriteLine($"Количество элементов в диапазоне [10, 99] = {countResult}");