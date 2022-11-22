// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21


using static System.Console;
Clear();
double x1 = Convert.ToDouble(ReadLine());
double y1 = Convert.ToDouble(ReadLine());
double x2 = Convert.ToDouble(ReadLine());
double y2 = Convert.ToDouble(ReadLine());

double s = Math.Sqrt( Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
WriteLine(s);