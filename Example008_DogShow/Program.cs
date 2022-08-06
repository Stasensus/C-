int count = 0;
int distance = 10000;
int firstfriendspeed = 1;
int secondfriendspeed = 2;
int dogspeed = 5;
int friend = 2;
int time = 0;

while(distance > 10)
{
    
    if (friend == 1)
    {
        time = distance / (firstfriendspeed + dogspeed);
        friend = 2;
    }
    if (friend == 2)
    {
        time = distance / (secondfriendspeed + dogspeed);
        friend = 1;
    }
    distance = distance - (firstfriendspeed + secondfriendspeed) * time;
    count = count + 1;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");