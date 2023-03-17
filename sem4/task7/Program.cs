/* 28. Напишите программу, которая принимает 
на вход число N и выдаёт произведение чисел от 1 до N.
4 → 24
5 → 120 == 1 * 2 * 3 * 4 * 5 */

Console.Clear();
Console.Write("Insert N number: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Произведение числа {number} -> {GetSum(number)}");

int GetSum (int number)
{
  int sum = 1;
  for (int i = 1; i <= number; i++)
  {
    sum = sum * i; // 1 * 1   1 * 2   2 * 3 
  }
  return sum;
}

