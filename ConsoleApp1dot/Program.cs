static string GetGreeting(string name, int visitCount) => visitCount switch
{
    1 => $"Welcome, {name}!",
    _ => $"Welcome back, {name}! Visit #{visitCount}."
};
Console.WriteLine("Enter your name:");
var name = Console.ReadLine();
Console.WriteLine(GetGreeting(name, 2));