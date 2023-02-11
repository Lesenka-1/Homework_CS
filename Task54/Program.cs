// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArr()
{
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

void Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    int[] arr = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        arr[j] = array[i,j];
    }
    Sort(arr);
    for (int k = 0; k < array.GetLength(1); k++)
    {
        array[i,k] = arr[k];
    }
}

PrintArr(array);