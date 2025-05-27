// See https://aka.ms/new-console-template for more information

// Variables are declared by their type
using System.Reflection.Metadata;

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
// List<string> sportsGear =
// [
//     "Football",
//     "Hockey Stick",
//     "Boomerang",
//     "Frisbee",
//     "Golf Putter"
// ];

List<Product> sportsGear = new List<Product>()
{
    new Product()
    {
        Name = "Football",
        Price = 15,
        Sold = false,
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 25,
        Sold = true,
    },
    new Product()
    {
        Name = "Boomerang",
        Price = 19,
        Sold = false,
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 2,
        Sold = true,
    },
    new Product()
    {
        Name = "Golf Putter",
        Price = 50,
        Sold = true,
    }
};

Console.WriteLine("Please, choose an option: ");

int counter = 0;

for (int i = 0; i < sportsGear.Count; i++)
{
    if (sportsGear[i].Sold == true)
    {
        continue;
    }
    else
    {
        counter++;
        Console.WriteLine($"{counter}. ${sportsGear[i].Price} {sportsGear[i].Name}");
    }
}

// This method receives user-input in the console and stores it in the variable
int response = int.Parse(Console.ReadLine().Trim());

// A while loop's function body will execute only when the parameter evaluates to true
while (response > counter || response < counter)
// IsNullOrEmpty does not account for whitespace
{
    Console.WriteLine($"Please, choose a number between 1 and {counter}");
    response = int.Parse(Console.ReadLine().Trim());
}

Console.WriteLine($@"You chose: {sportsGear[response].Name}
Thank you for your input!");