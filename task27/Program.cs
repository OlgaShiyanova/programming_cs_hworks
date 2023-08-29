// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт (количество цифр в числе) сумму цифр в числе.
// (452 -> 3) 452 -> 11  
// (82 -> 2) 82 -> 10   
// (9012 -> 4) 9012 -> 12

// (задача в скобочках)
// int Quantity(int num)
// {
//    if (num < 0) 
//        num = num * -1;
//        int count = 0;
//    while (num > 0)
//    {
//        num = num / 10;
//       count++;
//    }
//    return count;
// }

int SumDigites(int num)
{
    int sum = 0;
    int remainder = 1;
    if (num < 0) 
        num = num * -1;
        int count = 0;
    while (num > 0)
    {
        remainder = num % 10;
        num = num / 10;
        sum = sum + remainder;
        count++;
    }
    return sum;
}

Console.WriteLine("Ваше натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumdig = SumDigites(number);
// Console.WriteLine($"в вашем числе {quantity} знаков");
Console.WriteLine($"сумма цифр числа {sumdig}");