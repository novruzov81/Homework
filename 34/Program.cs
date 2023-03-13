/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2  */

double[] array = FillArray(10,100,1000);
int even = 0;
Print(array);
Console.Write($"Четных чисел в массиве -> {even}");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        even++;
}

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