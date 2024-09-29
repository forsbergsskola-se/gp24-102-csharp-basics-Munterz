/*
//P13_1Dollars
Console.WriteLine("Hey! How many dollars do you want?");
int dollar = int.Parse(Console.ReadLine());

Console.Write("Here's your dollars: ");
for (int i = 0; i < dollar; i++)
{
    Console.Write("$");
}


//P13_2Triangle
Console.WriteLine("Enter the desired size of your triangle");
int size = int.Parse(Console.ReadLine());

PrintTriangle:
for (int i = size; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
goto End;

End: ;


//P13_3Pattern
Console.WriteLine("Enter your desired size of the pattern");
int size = int.Parse(Console.ReadLine());
int row = 0;

PrintPattern:
if (row < size)
{
    if (row % 2 == 0)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("#-");
        }
    }
    else
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("-#");
        }
    }

    Console.WriteLine();
    row++;
    goto PrintPattern;
}


//Final exercise
Random random = new Random();
int myNumber = random.Next(1, 101);

Console.WriteLine("I have picked a number (1-100). It's your turn to guess it");

while (true)
{
    Console.WriteLine("Enter your guess:");
    int guess = int.Parse(Console.ReadLine());

    if (guess < myNumber)
    {
        Console.WriteLine("Nope! My number is Greater");
    }
    else if (guess > myNumber)
    {
        Console.WriteLine("Nope! My number is Lower");
    }
    else
    {
        Console.WriteLine("That's the number! Good Game!");
        break;
    }
}
*/

