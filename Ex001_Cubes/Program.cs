// Найти кубы чисел от 1 до N

using System;

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i < n; i++)
{
    Console.WriteLine($"{i} в кубе = {i * i * i}");
}