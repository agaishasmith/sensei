/* **Задача 19:** Напишите программу, которая принимает на 
вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да */

Console.Clear();
Console.Write("Enter a five-digit number: ");
int number = int.Parse(Console.ReadLine()!);

if (number >= 10000 && number < 1000000)
{
  // 12821
  int a = number / 1000; // 12821 / 1000 = 12
  int b = number % 100; // 12821 % 100 = 21    21 / 10 = 2; 21 % 10 = 1; 1*10+2
  int c = b / 10;
  int d = b % 10;
  int res = d * 10 + c; // 12
  if (res == a) // 12 == 12821
  {
    Console.WriteLine($"{number} -> палиндром");
  }
  else {
    Console.WriteLine($"{number} -> не палиндром");
  }
}
else 
{
  Console.WriteLine($"{number} -> не пятизначное число");
}