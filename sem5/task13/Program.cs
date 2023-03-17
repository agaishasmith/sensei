/* 32. Напишите программу замена элементов 
массива: 
положительные элементы замените на 
соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] */

Console.Clear();
Console.Write("Insert array length: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);
PrintArray(array);
ChangeElements(array);
PrintArray(array);

int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(-9, 10);
  }
  return array;
}
void PrintArray(int[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
  Console.WriteLine();
}

int[] ChangeElements(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = array[i] * -1;
  }
  return array;
}