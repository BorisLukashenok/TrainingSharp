// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine()!);
int maxABC = numberA;

if( numberA == numberB  &  numberA == numberC )
    Console.WriteLine("Числа равны.");
else
    {
        if( maxABC < numberB) maxABC = numberB;
        if( maxABC < numberC) maxABC = numberC;
        Console.WriteLine("Максимальное число: " + maxABC);
    }
