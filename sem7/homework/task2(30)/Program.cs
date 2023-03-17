/* **Задача 50.** Напишите программу, которая 
на вход принимает позиции элемента в двумерном 
массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Clear();
Console.Write("Insert rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Insert columns: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
Console.Write("Insert number: ");
int number = int.Parse(Console.ReadLine()!);

if (FindNumber(array, number) == false)
{
  Console.WriteLine($"{number} -> числа нет в массиве");
}

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

bool FindNumber(int[,] array, int number)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] == number)
      {
        Console.WriteLine("Number on {0}th row in {1}th column is {2}", i + 1, j + 1, number);
        return true;
        break;
      }
    }
  }
  return false;
}

