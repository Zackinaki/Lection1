Console.Write("Vvedite ima: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{   
    Console.WriteLine("Ura! Masha");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}