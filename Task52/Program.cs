﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4      Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите размер m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1,10);
    }
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}

PrintArr(arr);
Console.WriteLine();

double sum = 0;
Console.Write("Среднее арифметическое элементов в каждом столбце: ");
for (int j = 0; j < arr.GetLength(1); j++)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = sum + arr[i,j];
    }
    Console.Write($"{Math.Round(sum / m, 2)}; ");
    sum = 0;
}
Console.WriteLine("\b\b ");