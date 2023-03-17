/* 33. Задайте массив. Напишите программу, 
которая определяет, присутствует ли 
заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

Console.Clear();
Console.Write("Insert array length: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
PrintArray(array);

Console.Write("Insert number: ");
int number = int.Parse(Console.ReadLine()!);

FindElement(array, number);

int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(1, 100);
  }
  return array;
}
void PrintArray(int[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
  Console.WriteLine();
}

// bool -> true || false 

void FindElement(int[] array, int number)
{
  bool check = false;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == number)
    {
      check = true;
      break;
    }
    else
    {
      check = false;
    }
  }

  if (check == true)
  {
    Console.WriteLine("Да");
  }
  
  else 
  {
    Console.WriteLine("Нет");
  }
}

/* bool FindElement(int[] array, int number)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == number)
    {
      return true;
    }
  }
  return false;
} */

