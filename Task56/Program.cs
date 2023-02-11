// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArr()
{
    int m = new Random().Next(1,5);

    int[,] arr = new int[m, m];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-9,10);
        }
    }
    return arr;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArr();
PrintArr(array);
Console.WriteLine();

int minSum = 1000;
int minSumStr = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i,j];
    }
    if (sum < minSum) 
    {
        minSum = sum;
        minSumStr = i+1;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumStr}");