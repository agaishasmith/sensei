/* **Задача 64:** Задайте значение N. 
Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();
Console.Write("Insert N: ");
int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(GetNumber(n));
Console.Write($"{GetNumber(n)} ");

string GetNumber(int end)
{
  // int result = 0;

  /* for (int i = number; i >= 1; i--)
  {
    Console.Write($"{i} ");
  } */

  if (end == 1) 
  {
    return end.ToString();
  }
  string result = end.ToString() + " " + GetNumber(end - 1);
  return result;
}
