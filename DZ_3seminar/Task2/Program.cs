// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console;
Clear();

int[,] arrayOfPoint = new int[2, 3];

for (int i = 0; i < 2; i++)
{
    WriteLine($"Введите координаты {i + 1}ой точки в трехмерном пространстве");
    Write("Координата X: ");
    arrayOfPoint[i, 0] = int.Parse(ReadLine()!);
    Write("Координата Y: ");
    arrayOfPoint[i, 1] = int.Parse(ReadLine()!);
    Write("Координата Z: ");
    arrayOfPoint[i, 2] = int.Parse(ReadLine()!);
}

WriteLine($"Расстояние между точками: {Math.Round(Math.Sqrt(
    Math.Pow(arrayOfPoint[1, 0] - arrayOfPoint[0, 0], 2) +
    Math.Pow(arrayOfPoint[1, 1] - arrayOfPoint[0, 1], 2) +
    Math.Pow(arrayOfPoint[1, 2] - arrayOfPoint[0, 2], 2)),2)}");