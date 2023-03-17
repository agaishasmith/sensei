/* ### Задание 4. Работа в группах.

Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу квадратов чисел от 1 до N.
5 → 1, 4, 9, 16, 25
2 → 1, 4 */

Console.WriteLine("Enter number N: ");
int n = int.Parse(Console.ReadLine()!); // 5
int a = 1;
while (a <= n)
{
  Console.WriteLine(Math.Pow(a, 2));
  a++;
}