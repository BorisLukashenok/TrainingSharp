int count = 1,
    dist = 5000,
    firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpeed = 5,
    time = 0;

bool friend = false;

Console.Write("Расстояние между друзьями в тыс. км. : ");
dist = Convert.ToInt32(Console.ReadLine()) * 1000;

while(dist > 10)
{
    if(friend)
    {
        time = dist / (firstFriendSpeed + dogSpeed);
        friend = false;
    }
    else
    {
        time = dist / (secondFriendSpeed + dogSpeed);
        friend = true;
    }
    dist = dist - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.WriteLine("Собака пробежит " + count + " раз.");

