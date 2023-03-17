/* 67. Напишите программу, которая будет 
принимать на вход число и возвращать сумму его цифр. 

453 -> 12
45 -> 9 */

Console.Clear();
Console.Write("Insert number: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(number));

int GetSum(int number)
{
  int sum = 0;
  /* while (number > 0) // if (number == 0)
  {
    sum = sum + number % 10;
    number = number / 10; // 453 - 45 - 4
  } */

  if (number == 0) return 0;
  sum = number % 10 + GetSum(number / 10);

  return sum;
}


