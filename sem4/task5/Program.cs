/*24. Напишите программу, которая принимает на вход число А и
 выдаёт сумму чисел от 1 до А.
а = 5
sum = 1 + 2 + 3 + 4 + 5  */

Console.Clear();
Console.Write("Insert N number: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"sum = {GetSum(number)}");

int GetSum(int number)
{
  int sum = 0;
  for (int i = 1; i <= number; i++)
  {
    sum = sum + i;
  }
  return sum;
}