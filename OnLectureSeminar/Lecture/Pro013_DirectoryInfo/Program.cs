Console.Clear();
string path="G:/Scooling/Praktikum/1Chetvert/TrainingSharp";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
var fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
