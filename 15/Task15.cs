/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет  */

int num;
Console.Write ($"Введите день недели: ");
int.TryParse(Console.ReadLine()!, out num);

if (num > 5)
    Console.Write($"Это выходной");
else    
    Console.Write($"Это рабочий день");