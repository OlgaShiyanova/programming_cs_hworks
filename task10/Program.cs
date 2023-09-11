// // Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Ваше трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// ниже функция
 int SecondDigit(int num)
{
   int twodigit = num / 10 % 10;
    return (twodigit);
}
// используем функцию
if (number > 99 && number < 1000)
{
 //   z = SecondDigit(number);
    Console.WriteLine($"вторая цифра {SecondDigit(number)} ");
}
else 
{
    Console.WriteLine($"это НЕ трехзначное число. ");
}
