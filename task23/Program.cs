﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


using static System.Console;
Clear();

int N = int.Parse(ReadLine()); 
int i = 0;

for (i = 1; i <= N; i ++)
{
    Write($"{i*i*i}, ");
}


