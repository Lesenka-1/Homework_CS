// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11       82 -> 10         9012 -> 12

Console.WriteLine("Введите число");
int numA = Convert.ToInt32(Console.ReadLine());

int SumFig(int num)
{
    int kolvo = 1;
    int i = 10;
    while (num - i >= 0)
    {
        i = i * 10;
        kolvo++;
    }
    int result = 0;
    for (int j = 0; j < kolvo; j++)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

Console.WriteLine($"Сумма цифр в числе {numA} равна {SumFig(numA)}");

