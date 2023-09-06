//Задача 42:
// программа, котрая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int DecimalToBin(int num)
{
    int res = 0;
    int factor = 1;
    while(num > 0) // 13>0 ; 6>0
    {
        res = res + num % 2 * factor; // res = 1 ; 1+ 0 *10 =11
        num /= 2; // num = num / 2 // num = 6; 3
        factor *= 10; // factor = 10; 100
    }
    return res;
}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int decimalToBin = DecimalToBin(number);
Console.WriteLine(decimalToBin);

