// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
int maxAB = 0;

if( numberA == numberB ) 
    Console.WriteLine("Числа равны.");
else 
{
    if( numberA > numberB ) 
        maxAB = numberA;
    else
        maxAB = numberB;

    Console.Write("Максимальное число: " + maxAB);
}
    

