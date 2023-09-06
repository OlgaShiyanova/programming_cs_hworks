// Задача 40: Программа принимает на вход
// три числа и проверяет, может ли 
// существовать треугольник со сторонами
// такой длины.

Console.WriteLine("1 side: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 side: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3 side: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool InExistTriangle (int side1, int side2, int side3)
{
    if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side2 + side1)
    return true;
    else return false; 
}

bool result = InExistTriangle (num1, num2, num3);
Console.WriteLine(result? "Треугольник существует" : "треуг. не сущ.");