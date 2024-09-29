Console.WriteLine("Welcome to Nim!");
int totalMatches = 24;

while (totalMatches > 0)
{
    Console.WriteLine(new string('|', totalMatches));
    Console.WriteLine($"({totalMatches})");

    Console.WriteLine("How many matches do you want to draw?");
    int playerChoice = int.Parse(Console.ReadLine());

    while (playerChoice < 1 || playerChoice > 3 || playerChoice > totalMatches)
    {
        Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
        playerChoice = int.Parse(Console.ReadLine());
    }

    totalMatches -= playerChoice;

    if (totalMatches <= 0)
    {
        Console.WriteLine("You drew the last match. You lose.");
        break;
    }

    int aiChoice = new Random().Next(1, Math.Min(3, totalMatches) + 1);
    Console.WriteLine($"The AI draws {aiChoice} matches.");
    totalMatches -= aiChoice;

    if (totalMatches <= 0)
    {
        Console.WriteLine("The Ai drew the last match. You win!");
        break;
    }
}
