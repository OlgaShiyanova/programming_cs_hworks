// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int Stringtodigit(string message)// функция читае сообщение, 
// результат, введеная цифра = число
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool TheWeekend(int day)
//аргумент проверяется на сответствие выходному. 
// результат, логическая переменная
{
    if (day == 6 || day == 7)
    {
        return true;
    }
    return false;
}

// проверяем, введеная цифра должна быть в диапазоне от 1 до 7
// результат логическое да / нет
bool checkdigit(int number)
{
    if (number > 0 && number < 8)
    {
        return true;
    }
    else 
    {
    Console.WriteLine("Не то ввели. Введите цифру от 1 до 7");//если поменять
    return false;//  эти строчки, не будет сообщения выводить
    }
}

int Wday = Stringtodigit("День недели цифрой ");//в переменную Wday
// записываем цифру
if (checkdigit(Wday)) // если это день недели
{
    if (TheWeekend(Wday)) //если выдает true
    {
        Console.WriteLine("выходной");
    }
    else
    { Console.WriteLine("будни"); }
}


