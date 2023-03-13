/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double[] array = FillArray(10);

Print(array);

double min = 0;
double max = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    if (array[i] < min)
        min = array[i];
}
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементом массива = {max - min}");

void Print(Array arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr.GetValue(i)} ");
}

double[] FillArray(int size, double min = 0, double max = 10)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().NextDouble();
    return arr;
}