/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();
Console.Write("Insert number: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"sum = {GetSum(number)}");

int GetSum(int number)
{
  int sum = 0; // 0 + 2 = 2
  while (number > 0) // 45   
  {
    sum = sum + number % 10; // 452 % 10 = 2
                             // 45 % 10 = 5
                             // 4 % 10 = 0
                             // 2 + 5 = 7
    number = number / 10;    // 45
  }
  return sum;
}
