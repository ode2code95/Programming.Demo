// See https://aka.ms/new-console-template for more information

using Kantaiko.ConsoleFormatting;

Console.WriteLine("Hello, and welcome to our simple program demonstration!");
var firstName = Prompt("Please type your first name");
var lastName = Prompt("Please type your last name");
Console.WriteLine($"Why hello {firstName} {lastName}! Welcome to my programming workshop.\nThis is a blink test: ");

//Console.WriteLine(Decorations.Decoration("Blink", TextDecoration.Blink));
Console.WriteLine(Decorations.Italic("Custom Text").FgRed());

string? Prompt(string promptText)
{
    Console.WriteLine($"{promptText}: ");
    var userInput = Console.ReadLine();
    var allCaps = userInput?.ToUpper();
    return allCaps;
}