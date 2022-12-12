Console.WriteLine("Are you coming or leaving? (in/Out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}

static void PrintHello()
{
    Console.WriteLine("Hello Word!");
}
static void PrintGoodBye()
{
    Console.WriteLine("see you later aligator");
}