int count = 0;
float distance = 10000f;
float firstFriendSpeed = 1f;
float secondFriendSpeed = 2f;
float dogSpeed = 5f;
bool isFriend1 = false;
float time = 0f;

while (distance > 10.0f)
{

if (isFriend1)
{
    time = distance/(firstFriendSpeed + dogSpeed);
    isFriend1 = false;
}

else 
{
time = distance/(secondFriendSpeed + dogSpeed);
    isFriend1 = true;
}

distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;

count++;
}

Console.WriteLine();
Console.WriteLine("Cобака пробежит " + count + " раз.");
Console.WriteLine();
