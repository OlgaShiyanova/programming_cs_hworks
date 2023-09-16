// Задача 69: Принимает на вход число
// числа А и В. Возвращает А в степени B.
// а = 2 В =3 -> 8
// а = 3 В =2 -> 9

Console.WriteLine("введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int DegreeOfNumber(int a, int b) 
{
    if (a == 1 || b == 0) return 1;
    return a * DegreeOfNumber(a, b-1);
}

int degreeOfNumber = DegreeOfNumber(numberA, numberB);
Console.WriteLine(degreeOfNumber);
