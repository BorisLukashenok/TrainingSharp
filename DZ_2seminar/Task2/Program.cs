// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

using static System.Console;
Clear();

Write("Введите число: ");
string inputString = ReadLine()!;
if (inputString.Length > 2)
    WriteLine($"Третья цыфра: {inputString[2]}");
else
    WriteLine("Третьей цыфры нет!");