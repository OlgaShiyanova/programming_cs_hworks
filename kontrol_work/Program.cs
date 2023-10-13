//string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
//string[] array1 = new string[4] {"1234", "1567", "-2", "computer science"};
//string[] array1 = new string[3] {"Russia", "Denmark", "Kazan"};
string[] array1 = new string[4] {"-2", "1234", "1567", "computer science"}; //[4]-кол.элементов массива
string[] array2 = new string[array1.Length];

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0; // count = 0
    for (int i = 0; i < array1.Length; i++) // i= 0 , array1.length =4 0<4 
    {
    if(array1[i].Length <= 3) //считаем длину i-го элемента маccива 
        {
        array2[count] = array1[i]; //формируем новый массив c=0 -> array2: "-2"; __
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) //пока не дошел до конца массива 
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2); //не отрабатывет
PrintArray(array2);