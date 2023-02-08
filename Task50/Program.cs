// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4      1 7 -> такого числа в массиве нет    1 1 -> 9

int m = new Random().Next(1,10);
int n = new Random().Next(1,10);

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
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine();
    }
}

PrintArr(arr);
Console.WriteLine();

Console.Write("Введите позицию строки ");
int positionM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца ");
int positionN = Convert.ToInt32(Console.ReadLine());
if (positionM >= 0 && positionN >= 0) 
{
    if (positionM < arr.GetLength(0) && positionN < arr.GetLength(1)) Console.WriteLine(arr[positionM, positionN]);
    else Console.WriteLine("Такого элемента нет");
}
else Console.WriteLine("Данные введены неверно");