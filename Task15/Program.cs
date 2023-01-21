// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да     7 -> да     1 -> нет

//Console.WriteLine("Введите цифру от 1 до 7");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num==6 || num==7)
//{
//    Console.WriteLine("Выходной");
//}
//else
//{
//    Console.WriteLine("Не выходной");
//}

string week(int num)
{
    string day = "не выходной";
    if (num==6 || num==7) day = "Выходной";
    return day;
}
Console.WriteLine("Введите цифру от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(week(num));