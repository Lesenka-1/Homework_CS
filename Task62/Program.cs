// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] arr = new int[4,4];
int i = 0;
int j = 0;
int num = 0;
while (j < arr.GetLength(1)-1)
{
    arr[i,j] = num + 1;
    j++;
    num++;
} 
while (i < arr.GetLength(0)-1)
{
    arr[i,j] = num + 1;
    i++;
    num++;
}
while (j > 0)
{
    arr[i,j] = num + 1;
    j--;
    num++;
} 
while (i > 1)
{
    arr[i,j] = num + 1;
    i--;
    num++;
}
while (j < arr.GetLength(1)-2)
{
    arr[i,j] = num + 1;
    j++;
    num++;
} 
while (i < arr.GetLength(0)-2)
{
    arr[i,j] = num + 1;
    i++;
    num++;
}
while (j > 0)
{
    arr[i,j] = num + 1;
    j--;
    num++;
} 
 PrintArr(arr);
 