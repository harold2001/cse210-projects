// I have written a function called DisplayMenu that helps me have cleaner code. Additionally, I implemented a function called GetUserChoice that helps me validate whether the input data is a number or not. Finally, I created the HandleEntry function that allows me to handle the logic of adding a new journal entry.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new();
        PromptGenerator generator = new();

        Console.WriteLine("Welcome to the Journal Program!");

        int choice;
        do
        {
            DisplayMenu();
            choice = GetUserChoice();

            switch (choice)
            {
                case 1:
                    HandleAddEntry(myJournal, generator);
                    break;
                case 2:
                    myJournal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("What is the filename?");
                    string filenameLoad = Console.ReadLine();
                    myJournal.LoadFromFile(filenameLoad);
                    break;
                case 4:
                    Console.WriteLine("What is the filename?");
                    string filenameSave = Console.ReadLine();
                    myJournal.SaveToFile(filenameSave);
                    break;
                case 5:
                    Console.WriteLine("Exiting the Journal Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

        } while (choice != 5);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    static int GetUserChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        return choice;
    }

    static void HandleAddEntry(Journal myJournal, PromptGenerator generator)
    {
        string randomPrompt = generator.GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        string answer = Console.ReadLine();

        Entry newEntry = new(randomPrompt, answer);
        myJournal.AddEntry(newEntry);
    }
}