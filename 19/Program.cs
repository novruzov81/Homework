/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да  */


int a = TakeConsoleInt();

if (a/10000 < 10 & a/10000 >= 1) Polindrom(a);
else 
Console.WriteLine ("Введите пятизначное число");

void Polindrom(int a)
{
if (a/10000 == a%10 || a/1000%10 == a%100/10)
    Console.Write("Число является полиндромом");
else Console.Write("Число не является полиндромом");
}

int TakeConsoleInt(string str = "Введите число -> ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}