/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int a = TakeConsoleInt();

int[] array = CreateArray();
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

int[] CreateArray()
{
    int[] t_array = new int[8];
    for (int i = 0; i < 8; i++)
    t_array[i] = new Random().Next(0,1000);
    return t_array;
}

int TakeConsoleInt(string str = "Введите число -> ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
}