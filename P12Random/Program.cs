/*
//P12_1Random_Coordinates
Random random = new Random();
int x = random.Next(1,101);
int y = random.Next(1,101);

Console.WriteLine($"Enemy coordinates: X = {x}, Y = {y}");

//P12_2Random_Password
Random random = new Random();
string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVW0123456789!@#$%^&*()_+{}|:\"<>?";

string password = "";

for (int i = 0; i < 6; i++)
{
    int index = random.Next(chars.Length);
    char randomChar = chars[index];
    password += randomChar;
}

Console.WriteLine($"Generated password: {password}");


//P12_3Random_Item
string[] items = { "Sword", "Shield", "Bow", "Gun", "Knife" };
Random random = new Random();
int index = random.Next(items.Length);
string droppedItem = items[index];

Console.WriteLine($"You acquried: {droppedItem}");


//P12_4Random_Chance
Random random = new Random();
double chance = random.NextDouble();
if (chance <= 0.1)
{
    Console.WriteLine("You did it! This was a 10% chance of happening");
}
else
{
    Console.WriteLine("Try again!");
}


//Final Exercise
Console.WriteLine("Please pass me a seed");
int seed = int.Parse(Console.ReadLine());

Random random = new Random(seed);
int randomNumber1 = random.Next(0, 5);
int randomNumber2 = random.Next(0, 5);
int randomNumber3 = random.Next(0, 5);

Console.WriteLine(randomNumber1);
Console.WriteLine(randomNumber2);
Console.WriteLine(randomNumber3);

double randomDouble1 = random.NextDouble() * 0.5;
double randomDouble2 = random.NextDouble() * 0.5;
double randomDouble3 = random.NextDouble() * 0.5;

Console.WriteLine(randomDouble1);
Console.WriteLine(randomDouble2);
Console.WriteLine(randomDouble3);

double randomDouble4 = random.NextDouble() * (0.7 - 0.2) + 0.2;
double randomDouble5 = random.NextDouble() * (0.7 - 0.2) + 0.2;
double randomDouble6 =random.NextDouble() * (0.7 - 0.2) + 0.2;

Console.WriteLine(randomDouble4);
Console.WriteLine(randomDouble5);
Console.WriteLine(randomDouble6);

Console.WriteLine("Give me a crit chance between 0.0 (0%) and 1.0 (100%)");
double critChance = double.Parse(Console.ReadLine());

for (int i = 0; i < 5; i++)
{
    double roll = random.NextDouble();
    if (roll < critChance)
    {
        Console.WriteLine("Crit");
    }
    else
    { 
        Console.WriteLine("No Crit");
    }
}
*/