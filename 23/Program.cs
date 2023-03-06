/* Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int a = TakeConsoleInt();

Console.WriteLine(Cube(a));

int Cube(int a)
{
    int cub = 0;
    for (int i = 1; i <= a; i++)
        cub = i * i * i;
        Console.WriteLine(cub);
    return cub;
}

int TakeConsoleInt(string str = "Введите число -> ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}
