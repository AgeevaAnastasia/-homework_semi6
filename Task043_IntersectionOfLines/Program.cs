using System;
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите значение b1: ");
int b1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите значение k1: ");
int k1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = Int32.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = Int32.Parse(Console.ReadLine());

Console.Write("Прямые, заданные уравнениями y = k1 * x + b1 и y = k2 * x + b2, пересекутся в точке ");

double a = b2 - b1;
double b = k1 - k2;
double x = Math.Round((a / b), 1);

// double x = Math.Round(((b2 - b1) / (k1 - k2)), 1);
double y = Math.Round((k1 * x + b1), 1);


Console.WriteLine($"x = {x}, y = {y}");
Console.WriteLine();