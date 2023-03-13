﻿/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0  */

int[] array = FillArray(10,0,10);
Print(array);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
        sum += array[i];
}
Console.Write($"Cумма элементов, стоящих на нечётных позициях = {sum}");

void Print(Array arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr.GetValue(i)} ");
}

int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min,max);
    return arr;
}