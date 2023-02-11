// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = new Random().Next(1,10);
int n = new Random().Next(1,10);
int[,] GetArr(int m, int n)
{
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

Console.WriteLine("Массив 1");
int[,] array1 = GetArr(m,n);
PrintArr(array1);
Console.WriteLine();
int[,] array2 = GetArr(m,n);
Console.WriteLine("Массив 2");
PrintArr(array2);
Console.WriteLine();
Console.WriteLine("Произведение массивов 1 и 2");
int[,] array3 = new int[m,n];
for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        array3[i,j] = array1[i,j] * array2[i,j];
    }
}
PrintArr(array3);