/*Задача 29: Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();
int[] array = GetArray();
PrintArray(array);

int[] GetArray() // int[] array = new int[];
                            // [           ]
                            // [ , , , , , , ]
                            // [ 5, 7, 3, 6, 9, 8, 55, 22]
{
  int size = new Random().Next(5, 10);
  int[] array = new int [size];
  for (int i = 0; i < size; i++) // 
  {
    array[i] = new Random().Next(8);
  }
  return array;
}

void PrintArray(int[] array) // (int number)
{
  Console.Write($"[{String.Join(", ", array)}]");
  
  Console.WriteLine();
}
