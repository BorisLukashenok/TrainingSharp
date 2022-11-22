//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

using static System.Console;
Clear();

int m = new Random().Next(100, 999);
WriteLine(m);
int a = m / 100;
int b = m % 10;
m = a * 10 + b;
WriteLine(m);