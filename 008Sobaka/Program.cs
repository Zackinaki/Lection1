int count = 0, time = 0;
int distance = 100;
int FistFriendSpeed = 1, SecondFriendSpeed = 2, DogSpeed = 5;
int friend = 2;
while(distance > 10)
{
    if(friend = 1)
    {
        time = distance/(FistFriendSpeed + DogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(SecondFriendSpeed + DogSpeed);
        friend = 1;
    }
    distance = distance - (FistFriendSpeed + SecondFriendSpeed)* time;
    count++;
}
Console.WriteLine("Sobaka");
Console.WriteLine(count);