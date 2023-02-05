// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[new Random().Next(1,11)];

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
    Console.WriteLine("\b]"); 
}
FillArray(array, 100, 1000);
PrintArray(array);

int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        res ++;
    }
}
Console.WriteLine("результат {0}", res);