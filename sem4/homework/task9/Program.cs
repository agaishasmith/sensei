/* Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */ 

Console.Clear();
Console.Write("Insert number A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Insert number B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"result = {GetStepen(A, B)}");

double GetStepen(double numberA, double numberB)
{
  double number = Math.Pow(numberA, numberB);
  return number;
}
