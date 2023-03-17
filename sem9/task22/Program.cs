// Задача 65:**Задайте значения M и N.
// Напишите программу, которая выведет все
// натуральные числа в промежутке от M 
// до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8" 

Console.Clear();
Console.Write("Insert m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Insert n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetNumber(m, n));

string GetNumber(int start, int end)
                //  1        n
{
  if (end == start)
  {
    //Console.WriteLine(end);
    return start.ToString();
  }
  string result = GetNumber(start, end-1)+ " " + end.ToString();
  //Console.WriteLine(result);
  return result;
}
