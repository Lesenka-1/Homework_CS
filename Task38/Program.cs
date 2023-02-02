// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[new Random().Next(2,11)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100,101);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine("\b\b ");

int min = 0;
int max = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine($"разница между максимальным ({max}) и минимальным ({min}) элементом массива равна {max - min}");