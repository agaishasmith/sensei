/* 30. Напишите программу, которая выводит массив 
из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1, 0, 1, 1, 0, 1, 0, 0]
a = new Random().Next(0, 2)
int a = new Random().Next(2) */

Console.Clear();
Console.Write("Insert size: "); // 15
int size = int.Parse(Console.ReadLine()!); // 15
int[] array = GetArray(size);

Console.Write($"[{String.Join(", ", array)}]");

int[] GetArray(int size)   // int GetNum (int number)
{
  int[] array = new int[size]; // 0 - 7

  for (int i = 0; i < size; i++) // [0] - 1, [1] - 
  {
    array[i] = new Random().Next(2);
  }
  return array;
}

void PrintArray(int[] array) // [0] 1 [1] 1 [2] 0 [3] 1 [4] 1 [5] 1 [6] 1 [7] 0
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}
