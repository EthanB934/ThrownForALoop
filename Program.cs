// See https://aka.ms/new-console-template for more information

// Variables are declared by their type
using System.Diagnostics.Metrics;
using System.Net;
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
        StockDate = new DateTime(2025, 05, 1),
        ManufactureYear = 2025
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 25,
        Sold = true,
        StockDate = new DateTime(2024, 12, 31),
        ManufactureYear = 2015
    },
    new Product()
    {
        Name = "Boomerang",
        Price = 19,
        Sold = false,
        StockDate = new DateTime(2025, 02, 14),
        ManufactureYear = 2000
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 2,
        Sold = true,
        StockDate = new DateTime(2025, 05, 26),
        ManufactureYear = 2025
    },
    new Product()
    {
        Name = "Golf Putter",
        Price = 50,
        Sold = true,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 1982
    }
};

Console.WriteLine("Please, choose an option: ");

int counter = 0;
List<Product> availableProducts = new List<Product>()
{

};

for (int i = 0; i < sportsGear.Count; i++)
{
    if (sportsGear[i].Sold == true)
    {
        continue;
    }
    else
    {
        availableProducts.Add(sportsGear[i]);
    }

}



for (int i = 0; i < availableProducts.Count; i++)
{
    counter++;
    Console.WriteLine($"{i + 1}. ${availableProducts[i].Price} {sportsGear[i].Name}");
}
// This method receives user-input in the console and stores it in the variable
int response = int.Parse(Console.ReadLine().Trim());

// A while loop's function body will execute only when the parameter evaluates to true
while (response > counter || response < 0)
// IsNullOrEmpty does not account for whitespace
{
    Console.WriteLine($"Please, choose a number between 1 and {counter}");
    response = int.Parse(Console.ReadLine().Trim());
}

// Gives the date and time when the program runs
DateTime now = DateTime.Now;

// The result of an expression involving date and time is a time span. 
TimeSpan timeInStock = now - sportsGear[response - 1].StockDate;

Console.WriteLine(
// TimeSpan types have the Day's property which just returns the Day value of the date time. 
    $@"
    You chose: {sportsGear[response - 1].Name}
    Time in stock: {timeInStock.Days} Days
    ");
