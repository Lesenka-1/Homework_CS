﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5      782 -> 8     918 -> 1

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<0) num=num*-1;
int num1 = num / 10;
Console.WriteLine(num1%10);