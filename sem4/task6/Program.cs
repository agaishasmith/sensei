/* 26. Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
456 → 3
78 → 2
89126 → 5 */

Console.Clear();
Console.Write("Insert number: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"total number of {number} -> {CalculateNumber(number)}");

int CalculateNumber(int number)
{
  int TotalNumber = 0;
  while (number > 0) // 456 > 0
  {
    number = number / 10; // 456 / 10 = 45 / 10 = 4 / 10 = 0
                          // 78 / 10 = 7 / 10 = 0
                          // 89126 / 10 = 8912 / 10 = 891 / 10 = 89 / 10 = 8 / 10 = 0
    TotalNumber++; // 456 -> 3
  }
  return TotalNumber;
}
