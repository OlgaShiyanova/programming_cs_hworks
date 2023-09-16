// задача 63. Задайте значение M и N.
// Напишите программу, которая 
// выведет все натуральные числа в промежутке от 1 до N.
//  M = 1; N = 5 -> "1, 2, 3, 4, 5"
//  M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите M натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1 || number2 < 1) 
{
    Console.Write($"введено не натуральное число.");
    return; //завершаем работу метода main - точки входа в приложение.
}

void IntegerNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        IntegerNumbers(num1 - 1, num2);
    }
    else if (num1 < num2)
    {
        Console.Write($"{num1} ");
        IntegerNumbers(num1 + 1, num2);
    }
    else Console.Write($"{num1} ");// влюбом случае сюда попадем если чистал убудт равны и нет необходиомсти проверять
}

IntegerNumbers(number1, number2);