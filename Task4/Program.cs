﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
    max = b;
if (c > max)
    max = c;
Console.WriteLine(max);