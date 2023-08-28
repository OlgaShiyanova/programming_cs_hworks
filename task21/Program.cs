// Задача 21: Напишите программу, которая 
// принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int coordinate1 = x1 - x2;
    int coordinate2 = y1 - y2;
    int coordinate3 = z1 - z2;
    double distance = Math.Sqrt(coordinate1 * coordinate1 + coordinate2 * coordinate2 + coordinate3 * coordinate3);
    return distance;
}

Console.WriteLine ("Введите координаты первой точки");
Console.Write("X: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты второй точки");
Console.Write("X: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinate2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(xCoordinate1, yCoordinate1, zCoordinate1, xCoordinate2, yCoordinate2, zCoordinate2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);

Console.WriteLine(resultRound);