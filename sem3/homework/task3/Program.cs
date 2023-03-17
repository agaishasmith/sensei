/* Задача 21:** Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();
Console.Write("Insert x1: "); int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Insert y1: "); int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Insert z1: "); int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Insert x2: "); int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Insert y2: "); int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Insert z2: "); int z2 = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"distance between {x1}, {y1}, {z1} and {x2}, {y2}, {z2} -> {distance:f2}");