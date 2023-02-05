// Задача 42. Напишите программу, которая будет преобразововать десятичное число в двоичное.
// 45 -> 101101    3 -> 11   2 -> 10

Console.WriteLine("Введите десятичное число ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num;
int count = 0;
for (count = 0; num1 >= 1; count++)
{
    num1 = num1 / 2;
}

int[] arr = new int[count];
int num2 = num;
for (int i = arr.Length - 1; i >= 0; i--)
{
    arr[i] = num2 % 2;
    num2 = num2 / 2;
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}
PrintArr(arr);

