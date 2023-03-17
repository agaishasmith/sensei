/* 69. Напишите программу, которая на вход принимает 
два числа A и B, и возводит число А 
в целую степень B с помощью рекурсии.

A = 3; B = 5-> 243(3⁵)
A = 2; B = 3-> 8 */

Console.Clear();
Console.Write("Insert number A: ");
double numberA = double.Parse(Console.ReadLine()!);
Console.Write("Insert number B: ");
double numberB = double.Parse(Console.ReadLine()!);
Console.WriteLine(GetStepen(numberA, numberB));

double GetStepen(double numberA, double numberB)
{
  //double stepen = Math.Pow(numberA, numberB);

  if (numberB == 0) return 1;
  double stepen = numberA * GetStepen(numberA, numberB - 1);

  return stepen;
}


