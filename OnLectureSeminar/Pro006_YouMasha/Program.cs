Console.Write("Здравствуйте. Как Вас зовут: ");
string name = Console.ReadLine();
if (name.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.WriteLine("Здравствуй " + name);
}