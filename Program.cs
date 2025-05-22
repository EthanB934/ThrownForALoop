// See https://aka.ms/new-console-template for more information

// Variables are declared by their type
string theMeaningOfLife = "forty-two";

// The @ is used to create multi-line strings called verbatim strings
string greeting = @"Welcome to Thrown for a Loop!
Your one-stop shop for used sporting equipment";

// ;'s are necessary at the end of lines as if complete thoughts
Console.WriteLine(greeting);
Console.WriteLine(theMeaningOfLife);

// Initialize a new instance of a list of integers (verbose)
List<int> years = new List<int>()
{
    512,
    561,
    956,
    410,
    1028
};

// Initializes a new instance of a list of strings (simplified)
List<string> sportsGear =
[
    "Football",
    "Hockey Stick",
    "Boomerang",
    "Frisbee",
    "Golf Putter"
];

Console.WriteLine("Please, choose an option: ");

for (int i = 0; i < sportsGear.Count; i++)
{
    Console.WriteLine($"{i + 1}. {sportsGear[i]}");
}

// This method receives user-input in the console and stores it in the variable
int response = int.Parse(Console.ReadLine().Trim());

// A while loop's function body will execute only when the parameter evaluates to true
while (response > 5 || response < 1)
// IsNullOrEmpty does not account for whitespace
{
    Console.WriteLine("Please, choose a number between 1 and 5");
    response = int.Parse(Console.ReadLine().Trim());
}

Console.WriteLine($@"You chose: {response}
Thank you for your input!");