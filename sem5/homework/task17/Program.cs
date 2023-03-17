/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих 
на нечётных позициях.
 
[3, 7, 23, 12] -> 19   
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Console.Write("Insert array length: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);
PrintArray(array);

Console.WriteLine($"Сумма нечётных чисел = {GetSumElemets(array)}");

// [8]
// [5], [9], [4], [6]
//  0    1    2    3
// 9 + 6

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

int GetSumElemets (int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 != 0)
    {
      sum = sum + array[i];
    }
  }
  return sum;
}
