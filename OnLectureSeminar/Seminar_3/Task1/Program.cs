// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

using static System.Console;
Clear();
int a=int.Parse(ReadLine()!);

if (a == 1)
    WriteLine("0<x<& 0<y<&");
else if (a == 2)
    WriteLine("0<x<-& 0<y<&");
else if (a == 3)
    WriteLine("0<x<-& 0<y<-&");
else if (a == 4)
    WriteLine("0<x<& 0<y<-&");
