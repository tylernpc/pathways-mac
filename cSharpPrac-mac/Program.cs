/* C# Syntax */
Console.WriteLine("Hello, World!");

/* C# Comments */
// Here is a single line comment
/* Here is a multi
line comment */

/* C# Variables */
// int
int myNum = 50;
// string
string myName = "Tyler";
// basic addition
int x = 5;
int y = 10;
Console.WriteLine(x + y);
// assigning var to additives
int a = 5;
int b = 10;
int c = a + b;
Console.WriteLine(c);
// comma splits
int d = 5, e = 6, f = 50;
Console.WriteLine(d + e + f);

/* C# Data Types */
int num = 9;
double myDoubleNum = 8.99;
char myLetter = 'A';
bool myBoolean = false;
string myText = "Hello, World!";
// booleans
bool yay = true;
bool nay = false;
// variables
string greeting = "Hello";
Console.WriteLine(greeting);
// type casting conversion method
int myInt = 10;
Console.WriteLine(Convert.ToString(myInt));

/* User Input */
Console.WriteLine("Enter Username: ");
string userName = Console.ReadLine();
Console.WriteLine("Username is: " + userName);
// Another Example
Console.WriteLine("Think of a number: ");
int myNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your number is: " + myNum);

/* operators */
Console.WriteLine(10 * 5);
Console.WriteLine(10 / 5);
int j = 10;
j++;
int z = 10;
z += 5;

/* math */
int xx = 5;
int yy = 10;
Console.WriteLine(Math.Max(x, y));
Console.WriteLine(Math.Sqrt(64));
Console.WriteLine(Math.Round(2.6));

/* interpolation */
string fName = "John";
string lName = "Doe";
string name = $"My full name is: {fName} {lName}";

// single values
string stringyFName = "Hello";
Console.WriteLine(stringyFName[0]);

// length of a string
string txt = "Hello";
Console.WriteLine(txt.Length);

// Uppercase Something
Console.WriteLine(txt.ToUpper());

// boolean
bool isCodingFun = true;
bool isFishTasty = false;
Console.WriteLine(isCodingFun);
Console.WriteLine(isFishTasty);

// ternary operator
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);

// while loop
int i = 1;
while (i < 6)
{
    Console.WriteLine(i);
    i++;
}

do
{
    Console.WriteLine(i);
    i++;
}
while (i < 6);