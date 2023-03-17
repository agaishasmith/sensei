/* **Задача 66:** Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();
Console.Write("Insert m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Insert n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(m, n));

int GetSum(int start, int end)
{
  int sum = 0;
  /*for (int i = start; i <= end; i++)
  //       i = 1        1  <= 15      1+1
  //       i = 2        2  <= 15      2+1

  //       i = 4        4  <= 8       4+1
  //       i = 5        5  <= 8       5+1
  {
    sum = sum + i;
  }*/

  if (end == start) return end;
  sum = GetSum(start, end - 1) + end;
  return sum;
  // или можно записать так:
  // return GetSum(start, end - 1) + end;
}



