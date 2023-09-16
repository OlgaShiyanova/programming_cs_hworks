// задача 63. Задайте значение N.
// Напишите программу, которая 
// выведет все натуральные числа в промежутке от 1 до N.
//  N = 5 -> "1, 2, 3, 4, 5"
//  N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

Console.WriteLine("Введите натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1) 
{
    Console.Write($"{number1} не натуральное число.");
    return; //завершаем работу метода main - точки входа в приложение.
}

void IntegerNumbers(int num1)
{
    if (num1 == 0) return;
    IntegerNumbers(num1 - 1);
    Console.Write($"{num1} ");
}

IntegerNumbers(number1);
