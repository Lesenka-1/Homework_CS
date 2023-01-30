// Задача 29: Напишите программу, которая задаёт массив из N элементов в заданном пользователем диапазоне и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]                6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите колличество элементов массива");
int lengthN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нижнюю границу диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = new int[lengthN];
void FillArray(int[] collection, int minD, int maxD)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(minD, maxD+1);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("["); 
    while (position < count)
    {
        Console.Write($"{col[position]},");
        position++;
    }
    Console.Write("\b]"); 
}
FillArray(array, min, max);
PrintArray(array);