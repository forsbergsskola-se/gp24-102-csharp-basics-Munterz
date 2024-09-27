/*
//P11IfElse
Console.WriteLine("What's your age?");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}

else if (age >= 13)
{
    Console.WriteLine("You are a teenager,");
}

else
{
    Console.WriteLine("You are a child.");
}

Console.WriteLine("Give me another integer.");
int otherNumber = int.Parse(Console.ReadLine());

int maxNumber = age > otherNumber ? age : otherNumber;
Console.WriteLine($"The maximum is: {maxNumber}");

if (maxNumber % 2 == 0)
{
    Console.WriteLine("That number is an even number.");
}
else
{
    Console.WriteLine("That number is an odd number.");
}


//P11_1Grades
Console.WriteLine("Enter your numerical grade");
int grade = int.Parse(Console.ReadLine());

if (grade >= 90 && grade <= 100)
{
    Console.WriteLine("A"); 
}
else if (grade >= 80 && grade <= 89)
{
Console.WriteLine("B");
}
else if (grade >= 70 && grade <= 79)
{
    Console.WriteLine("C");
}
else if (grade >= 60 && grade <= 69)
{
    Console.WriteLine("D");
}
else if (grade < 60)
{
    Console.WriteLine("F");
}


//P11_2MinMax
 Console.WriteLine("Enter the first number:");
 int number1 = int.Parse(Console.ReadLine());
 
 Console.WriteLine("Enter the second number:");
 int number2 = int.Parse(Console.ReadLine());
 
 Console.WriteLine("Enter the third number:");
 int number3 = int.Parse(Console.ReadLine());
 
 int min = number1;
 if (number2 < min) min = number2;
 if (number3 < min) min = number3;
 
 int max = number1;
 if (number2 > max) max = number2;
 if (number3 > max) max = number3;
 
 Console.WriteLine($"The minimum is: {min}");
 Console.WriteLine($"The maximum is: {max}");
 

//P11_3Characters
Console.WriteLine("Enter a single character please: ");
char character = Console.ReadLine()[0];

if (char.IsDigit(character))
{
Console.WriteLine("That's a digit");
}

else if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' ||
    character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U')
{
    Console.WriteLine("That's a vowel.");
}
else
{
    Console.WriteLine("That's a consonant");
}


//P11_4Calculator
Console.WriteLine("Enter two numbers:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the operation (+, -, *, /):");
char operation = Console.ReadLine()[0];

if (operation == '+')
{
    Console.WriteLine($"Result: {num1 + num2}");
}
else if (operation == '-')
{
    Console.WriteLine($"Result: {num1 - num2}");
}
else if (operation == '*')
{
    Console.WriteLine($"Result: {num1 * num2}");
}
else if (operation == '/')
{
    Console.WriteLine($"Result: {num1 / num2}");
}


//P11_5EvenOrOdd
Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("That's even.");
}
else
{
    Console.WriteLine("That's odd.");
}

