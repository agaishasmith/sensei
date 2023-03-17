/*51. Задайте двумерный массив. Найдите 
сумму элементов, находящихся на главной 
диагонали (с индексами (0,0); (1; 1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.Clear();
Console.Write("Insert rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Insert columns: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(GetSum(array));

int[,] GetArray(int rows, int columns)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}
void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

int GetSum(int[,] array)
{
  int sum = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == j)
      {
        sum = sum + array[i, j];
      }
    }
  }
  return sum;
}
