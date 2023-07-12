using System.Xml.Serialization;

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");


Console.WriteLine("What is your name?");
    string name =Console.ReadLine();

Console.WriteLine("Do you want to do the COIN FLIP CHALLENGE? (Yes/No)");
string choice = Console.ReadLine();

if (choice.ToLower() == "no")
{
    Console.WriteLine("You suck, Coward!");
    return;
}

int score = 0;

for  (int i = 0; i <= 5; i++)
{
    int randomNum = new Random().Next(2);

    Console.WriteLine($"\nRound {i}; Heads or Tails? ");
    string guess = Console.ReadLine().ToLower();
    
    if ((randomNum == 0 && guess == "heads") || (randomNum == 1 && guess == "tails"))
    {
        score++;
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine("HA! Incorrect!");
    }
}

Console.WriteLine($"\n{name}, your total score is: {score}");