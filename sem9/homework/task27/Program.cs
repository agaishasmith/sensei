/* **Задача 68:** Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9

m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();
Console.Write("Insert m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Insert n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetAkkerman(m, n));

int GetAkkerman(int m, int n)
{
  // m < 0, n < 0 
  // m > 0; m > 0; n == 0;  
  // m == 0
  if (m > 0 && n == 0) return GetAkkerman(m - 1, 1);
  else if (m > 0 && n > 0) return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
  else return n + 1;
}

