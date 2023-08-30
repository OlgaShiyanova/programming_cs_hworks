// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.
//  1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int Promt(string message)
{
    System.Console.Write(message); //выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //парсим числа
    return result; 
}

//метод - получаем случайные числа в массиве
int[] GenerateArry(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; //объявление массива
    Random random = new Random();
    for (int i = 0; i < Langth; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);//заполняем 
    // случайными цифрами из диапазона StarArr до EndArr
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");//вывод массива
    }
    System.Console.Write($"{array[array.Length - 1]}"); //продолжаем выводить массив 
    System.Console.WriteLine("]");
}

int Length = Promt("Длина массива: ");
int min = Promt("Начальное значение, для диапазона случ. чисел: ");
int max = Promt("Конечное значение, для диапазона: ");
int[] array = GenerateArry(Length, min, max); //заполняем массив случ. числами
PrintArray(array);