Console.WriteLine("Give me a number");
string input = Console.ReadLine();

float floatValue = float.Parse(input);
Console.WriteLine(floatValue);

int intValue = (int)floatValue;
Console.WriteLine(intValue);

int directIntValue = int.Parse(input);
Console.WriteLine(directIntValue);
