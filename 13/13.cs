﻿/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6   */

int num;
Console.Write ($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num);
int num2 = Math.Abs(num);
if (num2 > 99)
{  
    while (num2 > 999)
        num2 /= 10;
    Console.Write($"{num} -> {num2 % 10}");
}
else    
    Console.Write($"Третьей цифры нет");
