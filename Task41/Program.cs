// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2       1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Введите число {i+1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int PosNum(int[] arr)
{
int res = 0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] > 0) res ++;
}
return res;
}
Console.WriteLine($"Пользователь ввёл {PosNum(arr)} чисел больше 0");