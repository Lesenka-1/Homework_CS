// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)       2, 4 -> 16
Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());
int result = numA;
for (int i = 1; i < numB; i++)
{
    result = result * numA;
}
Console.WriteLine($"{numA} в степени {numB} равно {result}");