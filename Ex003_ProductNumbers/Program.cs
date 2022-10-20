// Написать программу вычисления произведения чисел от 1 до N

using System;

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int pr = 1;
for (int i = 1; i <= n; i++)
{
    pr = pr * i;
}
Console.WriteLine($"Произдеведение чисел от 1 до {n} = {pr}");