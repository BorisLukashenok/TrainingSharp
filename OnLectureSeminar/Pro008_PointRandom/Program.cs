Console.Clear();
//Console.SetCursorPosition(10, 4)

int ax = 40, ay = 1,
    bx = 1, by = 30,    
    cx = 80,cy = 30;

Console.SetCursorPosition(ax, ay);
Console.WriteLine("+");
Console.SetCursorPosition(bx, by);
Console.WriteLine("+");
Console.SetCursorPosition(cx, cy);
Console.WriteLine("+");

int x = ax, y = ay, count = 0 ;

while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x + ax) / 2;
        y = (y + ay) / 2;
    }
    if(what == 1)
    {
        x = (x + bx) / 2;
        y = (y + by) / 2;
    }
    if(what == 2)
    {
        x = (x + cx) / 2;
        y = (y + cy) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
