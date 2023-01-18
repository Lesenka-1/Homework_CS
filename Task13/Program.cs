// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5        78 -> третьей цифры нет      32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
if (num < 0) num1 = num * -1;
if (num1 < 100)
{
    Console.WriteLine("У числа {0} нет третьей цифры", num);
}
else
{
    while (num1 > 999)
    {
        num1 = num1 / 10;
    }
    Console.Write("Третья цифра числа {0} - это ", num);
    Console.WriteLine(num1 % 10);
}
