// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет    12821 -> да     23432 -> да
Console.WriteLine("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine()??"");

int num1 = (num%10)*100 + (num/10)%10*10 + (num/100)%10;
if (num/100==num1) Console.WriteLine("Число {0} является палиндромом", num);
else Console.WriteLine("Число {0} не является палиндромом", num);
