// See https://aka.ms/newatermelon weight-console-template for more information

using static System.Console;
Clear();

int watermelonWeight = int.Parse(ReadLine()!);
if (watermelonWeight % 2 > 0)
   WriteLine("Несмогут");
else
for (int i = 1; i < watermelonWeight; i++)
{
   if(i%2==0 && (watermelonWeight-i)%2==0)
   WriteLine($"{i},{watermelonWeight-i}");
}