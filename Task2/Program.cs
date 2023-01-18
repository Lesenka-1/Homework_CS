// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Число {0} больше числа {1}", num1, num2);
}
if (num2 > num1)
{
    Console.WriteLine("Число {0} больше числа {1}", num2, num1);
}
if (num1 == num2)
{
    Console.WriteLine("Число {0} равно числу {1}", num1, num2);
}