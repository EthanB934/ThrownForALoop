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
        Price = 8.99M,
        Sold = false,
        StockDate = new DateTime(2025, 05, 1),
        ManufactureYear = 2025,
        Condition = 2.32
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12.25M,
        Sold = true,
        StockDate = new DateTime(2024, 12, 31),
        ManufactureYear = 2015,
        Condition = 1.10
    },
    new Product()
    {
        Name = "Boomerang",
        Price = 30.10M,
        Sold = false,
        StockDate = new DateTime(2025, 02, 14),
        ManufactureYear = 2000,
        Condition = 3.88
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 1.80M,
        Sold = false,
        StockDate = new DateTime(2025, 05, 26),
        ManufactureYear = 2025,
        Condition = 5.00
    },
    new Product()
    {
        Name = "Golf Putter",
        Price = 150.99M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 1982,
        Condition = 4.84
    }
};


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

Product chosenProduct = null;

while (chosenProduct == null)
{
    int counter = 0;
    Console.WriteLine("Please, choose an option: ");
    for (int i = 0; i < availableProducts.Count; i++)
    {
        counter++;
        Console.WriteLine($"{i + 1}. ${availableProducts[i].Price} {sportsGear[i].Name}");
    }
    try
    {

        {
            Console.WriteLine($"Choose an option...");
            int response = int.Parse(Console.ReadLine().Trim());
            chosenProduct = availableProducts[response - 1];
        }
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine($@"
        
        Select a number from 1 to {counter}

        ");
    }
    catch (FormatException)
    {
        Console.WriteLine(@"

        The input must be a number!

        ");
    }
    catch (Exception ex)
    {
        Console.WriteLine($@"

            {ex}
        Do better!!!
        
        ");
    }

}

decimal availableProductsTotalCost = 0.0M;

foreach (var product in availableProducts)
{
    availableProductsTotalCost += product.Price;

}

// A while loop's function body will execute only when the parameter evaluates to true

// Gives the date and time when the program runs
DateTime now = DateTime.Now;

// The result of an expression involving date and time is a time span. 
TimeSpan timeInStock = now - chosenProduct.StockDate;

Console.WriteLine(
// TimeSpan types have the Day's property which just returns the Day value of the date time. 
    $@"
    You chose: {chosenProduct.Name}
    Time in stock: {timeInStock.Days} Days
    Throw For a Loop's Condition Rating: {chosenProduct.Condition}

    Total Stock Cost ---------- ${availableProductsTotalCost} ---------- 
    ");
