// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[new Random().Next(1,11)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine("\b\b ");

int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        res ++;
    }
}
Console.WriteLine("результат {0}", res);