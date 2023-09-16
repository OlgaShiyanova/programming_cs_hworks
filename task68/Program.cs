//68: написать программу вычисления 
// функции Аккермана,
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("введите число m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число n");
int numberN = Convert.ToInt32(Console.ReadLine());

int AnkermannFunction(int m, int n) 
{
//    if (n == 0) return m+1;
 //   else if (m == 0) return AnkermannFunction()
  //  {}
 while (n != 0)
 {
   if (m == 0)  
   {
        m = 1; 
   } 
    else m=AnkermannFunction(n, m - 1);
    n = n-1;
 }
 return m + 1;
}

int ankermannFunction = AnkermannFunction(numberM, numberN);
Console.WriteLine(ankermannFunction);