//Задача 23: Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeTable(int number)
{
  int counter = 1;
  while (counter <= number)
  {
    Console.WriteLine($"{counter} в кубе = {counter * counter * counter}"); // $ -формируем строку
    counter++;// увеличели счетчик на 1
  }
}

Console.Write("Введите натуральное число: ");
int cubenumber = Convert.ToInt32(Console.ReadLine());

CubeTable(cubenumber); //вызвали метод
