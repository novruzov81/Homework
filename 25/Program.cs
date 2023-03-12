/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int a = TakeConsoleInt("Введите число ");
int b = TakeConsoleInt("Введите степень ");
Console.WriteLine($"Число {a} в степени {b} = {Result(a, b)}");

int Result(int a, int b)
    {
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;    
        }
        return result;
    }

int TakeConsoleInt(string str = "Введите число -> ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}
