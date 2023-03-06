/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите 3 координаты точки А и 3 координаты точки B");
int Ax = TakeConsoleInt();
int Ay = TakeConsoleInt();
int Az = TakeConsoleInt();
int Bx = TakeConsoleInt();
int By = TakeConsoleInt();
int Bz = TakeConsoleInt();

Console.WriteLine($"Расстояние между точками = {Math.Sqrt(Math.Pow((Ax - Bx),2) + Math.Pow((Ay - By),2) + Math.Pow((Az - Bz),2))}");

int TakeConsoleInt(string str = "Введите координату -> ")
{
    int num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out num);
    return num;
} 
