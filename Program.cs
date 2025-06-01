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

string choice = null;
while (choice != "0" && choice != "1")
{
    Console.WriteLine(@"
    
    Choose an option...
    0. Exit
    1. View Product Details

    ");

    choice = Console.ReadLine().Trim();

    if (choice == "0")

    {
        Console.WriteLine("Goodbye!");
    }

    else

    {
        choice = null;
        ViewProductDetails();
    }
}

void ViewProductDetails()
{
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
        for (int i = 0; i < availableProducts.Count; i++)
        {
            counter++;
            Console.WriteLine($"{i + 1}. ${availableProducts[i].Price} {availableProducts[i].Name}");
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

    DateTime now = DateTime.Now;

    TimeSpan timeInStock = now - chosenProduct.StockDate;

    Console.WriteLine(
        $@"
    Product:          ------------ {chosenProduct.Name}
    Time in stock:    ------------ {timeInStock.Days} Days
    Condition:        ------------ {chosenProduct.Condition}
    Cost:             ------------ S{chosenProduct.Price}
    Total Stock Cost: ------------ ${availableProductsTotalCost}
    ");

    Console.WriteLine("Press the enter key to continue...");
    Console.ReadLine();
}

