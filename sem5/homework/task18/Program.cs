/* **Задача 38:** Задайте массив вещественных 
чисел. Найдите разницу между максимальным и 
минимальным элементов массива.

[3 7 22 2 78] -> 76
78 - 2 */

Console.Clear();
Console.Write("Insert array length: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);
PrintArray(array);

Console.WriteLine($"Разница между макс и мин = {MaxMinDifference(array)}");

int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(1, 10);
  }
  return array;
}
void PrintArray(int[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
  Console.WriteLine();
}

int MaxMinDifference(int[] array)
{
  int diff = 0, max = 0, min = 10;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
  }
  diff = max - min;
  return diff;
}

