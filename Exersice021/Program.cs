/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.WriteLine ("Введите координату x первой точки: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату y первой точки: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату z первой точки: ");
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine ("Введите координату x второй точки: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату y второй точки: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату z второй точки: ");
double z2 = double.Parse(Console.ReadLine());

double range = Math.Round(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)), 2);
Console.WriteLine ($"расстояние равно: {range}");