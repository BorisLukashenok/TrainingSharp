int a = new Random().Next(1, 11);
int b = new Random().Next(1, 11);
int c = new Random().Next(1, 11);
int d = new Random().Next(1, 11);
int e = new Random().Next(1, 11);
int max = a;

Console.WriteLine("Вес гирь: " + a + " " + b + " " + c + " " + d + " " + e);


if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine("Максимальный вес: " + max);