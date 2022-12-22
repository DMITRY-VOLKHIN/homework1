// Задача 21 ....напишите программу, которая принимает на вход координаты двух точек и находить расстояние между ними в 3D пространсве.
Console.Write("Введите координаты x для точки A: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Введите координаты x для точки A: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Введите координаты x для точки A: ");
int cA = int.Parse(Console.ReadLine());

Console.Write("Введите координаты x для точки B: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Введите координаты x для точки B: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("Введите координаты x для точки B: ");
int cB = int.Parse(Console.ReadLine());

double distance = 0;
// ((xb - xa)2 + (yb - ya)2)
distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB,2) + Math.Pow(cA - cB, 2));
Console.WriteLine(Math.Round(distance, 2));