// Задача 43:
//программа, которая найдёт точку пересечения
// двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1 * x + b1 = k2 * x + b2 
// k1 * x - k2 * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)

using System.Runtime.Intrinsics.X86;

int Promt(string message)
{
    Console.Write(message); //вывести сообщение
    string value = Console.ReadLine(); //считывает с консоли строку
    int result = Convert.ToInt32(value); //преобразует строку в целое число
    return result;
}

double b1Var = Promt("Введите b1 -> ");
double k1Var = Promt("Введите k1 -> ");
double b2Var = Promt("Введите b2 -> ");
double k2Var = Promt("Введите k2 -> ");

double CoordX(double b1Coord, double k1Coord, double b2Coord, double k2Coord)
{
        double xCoord = (b2Coord - b1Coord) / (k1Coord - k2Coord);
        double point1 = xCoord; 

        return point1;
}
double CoordY(double b1Coord, double k1Coord, double xCoord)
{
        double point2 = k1Coord * xCoord + b1Coord; 

        return point2;
}
double point1 = CoordX(b1Var, k1Var, b2Var, k2Var);
double point2 = CoordY(b1Var, k1Var, point1);
Console.WriteLine();
Console.WriteLine($"b1 = {b1Var}, k1 = {k1Var}, b2 = {b2Var}, k2 = {k2Var} -> ({point1};{point2})");