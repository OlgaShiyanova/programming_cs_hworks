// Задача 13: Напишите программу, 
// которая выводит третью цифру 
// заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
//  функция выводит третье число
 int thirdDigit(int num)
{
    while (num > 999) 
    {
      num = num/10;  
    } 
   int digit = num % 10;
    return (digit);
}

if (number > 99)
{
   Console.WriteLine($"ищем цифру {thirdDigit(number)}");
}
else 
{
     Console.WriteLine("третьей цифры нет");
}
