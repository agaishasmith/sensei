/* Задача 34: Задайте массив заполненный 
случайными положительными трёхзначными 
числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();
Console.Write("Insert array length: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);
PrintArray(array);

Console.WriteLine($"Количество чётных чисел = {GetEvenNumbers(array)}");

int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
  return array;
}
void PrintArray(int[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
  Console.WriteLine();
}

int GetEvenNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}
