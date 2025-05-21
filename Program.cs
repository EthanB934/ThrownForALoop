// See https://aka.ms/new-console-template for more information

// Variables are declared by their type
string theMeaningOfLife = "forty-two";

// The @ is used to create multi-line strings called verbatim strings
string greeting = @"Welcome to Thrown for a Loop!
Your one-stop shop for used sporting equipment";

// ;'s are necessary at the end of lines as if complete thoughts
Console.WriteLine(greeting);

Console.WriteLine("Please, choose an option: ");

Console.WriteLine(theMeaningOfLife);

// This method receives user-input in the console and stores it in the variable
string response = Console.ReadLine().Trim();

// A while loop's function body will execute only when the parameter evaluates to true
while (string.IsNullOrWhiteSpace(response))
// IsNullOrEmpty does not account for whitespace
{
    Console.WriteLine("You made no choice!");
    response = Console.ReadLine().Trim();
}

Console.WriteLine($@"You chose: {response}
Thank you for your input!");