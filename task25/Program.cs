// Задача 25: Напишите программу,
// которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, 
// встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int SumNumbers(int n)
{
    int sum = 0;
    // for (count <) // если известно количество итераций
    // если неизвестно количество итераций использовать while
    for (int i = 0; i <= n; i++)
    {
        sum = sum + i; //как вариант можно sum += i 
        //если одно действие, можно не использовать {{ скобки}}
    }
    return sum;
}

Console.WriteLine("Введите число А");
int aNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int bNumber = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(aNumber); //лучше делать переменную на этом этапе
Console.WriteLine(result);