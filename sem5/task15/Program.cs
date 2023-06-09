﻿/* 35. Задайте одномерный массив из 123 
случайных чисел [0: 1000].
Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. 
В своём решении сделайте для 123

[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5 */

Console.Clear();
int size = 123;
int[] array = GetArray(size);
PrintArray(array);
Console.WriteLine($"Количество двухзначных элементов = {GetCountElements(array)}");

int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(0, 1000+1);
  }
  return array;
}
void PrintArray(int[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
  Console.WriteLine();
}

int GetCountElements(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= 10 && array[i] <= 99)
    {
      count = count + 1; // count++;
    }
  }
  return count;
}