
/*P90Operators
Console.WriteLine("Give me a number of seconds:");
int TotalSeconds = int.Parse(Console.ReadLine());

int days = TotalSeconds / 86400;
TotalSeconds %= 86400;

int hours = TotalSeconds / 3600;
TotalSeconds %= 3600;

int minutes = TotalSeconds / 60;
int seconds = TotalSeconds % 60;

Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");
    
Console.WriteLine($"{days}.{hours:D2}:{minutes:D2}:{seconds:D2}");

double TotalDays = (double)TotalSeconds / 86400;
Console.WriteLine($"In total, that's {days + TotalDays} Days.");


//P09_01
Console.WriteLine ("Enter speed in km/h:");
float KmPerHour = float.Parse(Console.ReadLine());
float MeterPerSecond = KmPerHour / 3.6f;
Console.WriteLine(MeterPerSecond);


//P09_02
Console.WriteLine ("Enter minutes");
int Minutes = int.Parse(Console.ReadLine());
int Seconds = Minutes * 60;
Console.WriteLine($"In total that's {Seconds} seconds.");


//P09_03
Console.WriteLine("Enter two integers:");
float dividend = float.Parse(Console.ReadLine());
float divisor = float.Parse(Console.ReadLine());
float DivisionResult = (float)dividend / divisor;
Console.WriteLine(DivisionResult);


//P09_04
Console.WriteLine("Enter two integers for remainder:");
int DividendRemainder = int.Parse(Console.ReadLine());
int DivisorRemainder = int.Parse(Console.ReadLine());
int ReminderResult = DividendRemainder % DivisorRemainder;
Console.WriteLine(RemainderResult);


//P09_05
Console.WriteLine("Enter the radius of a circle:");
float radius = float.Parse(Console.ReadLine());
float circleArea = (float) (Math.PI * Math.Pow(radius, 2));
Console.WriteLine(circleArea);


//P09_06
Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(-number); 


//PO9_07
Console.WriteLine("Enter two numbers for product");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int product = num1 * num2;
Console.WriteLine(product);


//P09_08
Console.WriteLine("Enter your weight in kilograms");
float weight = float.Parse(Console.ReadLine());
Console.WriteLine("Enter your height in meters");
float height = float.Parse(Console.ReadLine());
float bmi = weight / (height * height);
Console.WriteLine(bmi);


//P09_09
Console.WriteLine("Enter the lengths of two sides of a right triangle:");
float side1 = float.Parse(Console.ReadLine());
float side2 = float.Parse(Console.ReadLine());
float hypotenuse = (float)Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
Console.WriteLine(hypotenuse);
*/

//P09_10
Console.WriteLine("Enter seconds");
int inputSeconds = int.Parse(Console.ReadLine());
int minutes = inputSeconds / 60;
int seconds = inputSeconds % 60;
Console.WriteLine($"{minutes} minute(s) and {seconds} second(s)");

