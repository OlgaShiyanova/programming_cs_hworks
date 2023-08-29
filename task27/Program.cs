// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт (количество цифр в числе) сумму цифр в числе.
// (452 -> 3) 452 -> 11  
// (82 -> 2) 82 -> 10   
// (9012 -> 4) 9012 -> 12

int Quantity(int num);
{
    if (num < 0) then num = num * -1;
    int count = 0;
    while (num => 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Ваше натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int quantity = Quantity(number);
Console.WriteLine($"в вашем числе" {quantity} "знаков");