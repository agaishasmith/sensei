/* 31. Задайте массив из 12 элементов, 
заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов
 массива. */

Console.Clear();
int size = 12;
int[] array = GetArray(size);
PrintArray(array);

Console.WriteLine($"Negative sum = {GetSumNegative(array)}, positive sum = {GetSumPositive(array)}");

int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(-9, 9);
  }
  return array;
}

int GetSumNegative (int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < 0)
    {
        sum = sum + array[i];
    }
  }
  return sum;
}

int GetSumPositive (int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
        sum = sum + array[i];
    }
  }
  return sum;
}

void PrintArray(int[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
  Console.WriteLine();
}

