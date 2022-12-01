double RememberUserInput(string text)
{
    Console.WriteLine (text);
    double input = Convert.ToDouble(Console.ReadLine());
    return input;
}

double b1 = RememberUserInput("Ведите первую координату первой прямой b1:");
double k1 = RememberUserInput("Ведите вторую координату первой прямой k1:");
double b2 = RememberUserInput("Ведите первую координату второй прямой b2:");
double k2 = RememberUserInput("Ведите вторую координату второй прямой k2:");

void CrossPoint (double b1,double b2,double k1,double k2)
{
double x = (b2-b1)/(k1-k2);
double y = (k1*x+b1);
Console.WriteLine ($"точка пересечения прямых x= {x} и y= {y}");
}
CrossPoint (k1,k2,b1,b2);