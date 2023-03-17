/* **Задача 47**. Задайте двумерный массив 
размером m×n, заполненный случайными 
вещественными числами.
new Random().NextDouble( ) * ;
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Clear();
Console.Write("Insert rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Insert columns: ");
int columns = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(rows, columns);
PrintArray(array);

double[,] GetArray(int rows, int columns)
{
  double[,] array = new double[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().NextDouble() * (10 - (-10)) + (-10); // 0,2
    }
  }
  return array;
}
void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]:f1} ");
    }
    Console.WriteLine();
  }
}
