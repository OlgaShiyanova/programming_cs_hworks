﻿// Напишите программу, которая 
// принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите 5ти значное число");
int number = Convert.ToInt32(Console.ReadLine()); 

// void CheckingNumber(string number){
//  if (number[0]==number[4] || number[1]==number[3]){
//    Console.WriteLine($"Ваше число: {number} - палиндром.");
//  }
//  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

if (number < 100000) //проверка на 5ти значность
{
  if (number % 10 == number / 10000 && number / 10 % 10  == number / 1000 % 10)
    {
      Console.WriteLine ($"полиндром");
    }
   else 
   {
    Console.WriteLine ($"не является полиндромом");  
   }
}
else 
{ 
  Console.WriteLine("Введи правильное число");
}