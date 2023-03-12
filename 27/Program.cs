/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12  */

int a = TakeConsoleInt();
Console.WriteLine($"Сумма цифр в числе {a}={int Sum()}");

int Sum()
{
    int sum = 0;
    while (a > 0)
        {
            sum += a%10;
            a = a/10;
        }
    return sum;
}

int TakeConsoleInt(string str = "Введите число -> ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}