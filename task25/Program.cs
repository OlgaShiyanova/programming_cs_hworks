// Задача 25: Напишите программу,
// которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, 
// встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DegreeNumber(int a, int b)
{
    int ndegree = 1;
    // for (count <) // если известно количество итераций
    // while // если неизвестно количество итераций 
    for (int i = 1; i <= b; i++)
    {
        ndegree = ndegree * a; //как вариант можно sum += i 
        //если одно действие, можно не использовать {{ скобки}}
    }
    return ndegree;
}

Console.WriteLine("Введите число А");
int aNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int bNumber = Convert.ToInt32(Console.ReadLine());

int result = DegreeNumber(aNumber, bNumber); //лучше делать переменную на этом этапе
Console.WriteLine(result);