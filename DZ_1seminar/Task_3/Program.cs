// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число, я проверю его на чётность: ");
int number = int.Parse(Console.ReadLine()!);

if( number % 2 == 0)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");