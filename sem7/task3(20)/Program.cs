/* 49. Задайте двумерный массив. 
Найдите элементы, у которых оба индекса 
чётные, и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:

1 4 7 2
5 9 2 3
8 4 2 4
1 2 3 4

Новый массив будет выглядеть вот так:

1 4 7 2
5 **81** 2 **9**
8 4 2 4
1 **4** 3 **16** */

Console.Clear();
Console.Write("Insert rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Insert columns: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
GetNewArray(array);
PrintArray(array);

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

int[,] GetNewArray(int[,] array)
{
  for (int i = 1; i < array.GetLength(0); i += 2)
  {
    for (int j = 1; j < array.GetLength(1); j += 2)
    {
      array[i, j] = array[i, j] * array[i, j];
    }
  }
  return array;
}

