// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19      [-4, -6, 89, 6] -> 0

int[] array = new int[new Random().Next(1,11)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100,101);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine("\b\b ");

int res = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    res = res + array[i];
}
Console.WriteLine("сумма элементов, стоящих на нечётных позициях = {0}", res);