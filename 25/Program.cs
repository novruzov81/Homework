/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int a = TakeConsoleInt();

int TakeConsoleInt(string str = "Введите число -> ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}
