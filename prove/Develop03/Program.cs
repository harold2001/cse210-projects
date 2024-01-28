// The user creates a scripture reference and a scripture.
// The user can guess about the hidden words using one letter at a time.
// The user can hide words from the ones that are not hidden.
using System;

class Program
{
    static void Main(string[] args)
    {
        // The user creates a scripture reference and a scripture.
        Reference reference = GetScriptureReference(); ;
        Scripture scripture = CreateScripture(reference);

        string answer;
        do
        {
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine("Press enter to continue, write a letter and press enter to guess, or type 'quit' to finish.");
            answer = Console.ReadLine();

            ProcessUserInput(answer, scripture);

        } while (answer != "quit" && !scripture.IsCompletelyHidden());

        Console.Clear();
        scripture.GetDisplayText();
        Console.WriteLine("Thank you! Come back soon!");
    }

    static Reference GetScriptureReference()
    {
        Console.WriteLine("------ Let's create a scripture! ------");
        Console.WriteLine("--- Let's create the reference for the scripture ---");

        Console.Write("Enter the book (example - Proverbs): ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter (example - 3): ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Does the scripture have more than 1 verse? (Y/N): ");
        string answerVerses = Console.ReadLine().ToLower();

        if (answerVerses == "y")
        {
            Console.Write("Enter the first verse (example - 5): ");
            int startVerse = int.Parse(Console.ReadLine());

            Console.Write("Enter the last verse (example - 6): ");
            int endVerse = int.Parse(Console.ReadLine());

            return new Reference(book, chapter, startVerse, endVerse);
        }
        else if (answerVerses == "n")
        {
            Console.Write("Enter the verse (example - 5): ");
            int singleVerse = int.Parse(Console.ReadLine());
            return new Reference(book, chapter, singleVerse);
        }
        else
        {
            Console.WriteLine("Invalid input. Assuming single verse.");
            Console.Write("Enter the verse (example - 5): ");
            int singleVerse = int.Parse(Console.ReadLine());
            return new Reference(book, chapter, singleVerse);
        }
    }

    static Scripture CreateScripture(Reference reference, string text = "")
    {
        if (string.IsNullOrEmpty(text))
        {
            Console.Write("Enter the scripture text: ");
            text = Console.ReadLine();
        }

        return new Scripture(reference, text);
    }

    static void ProcessUserInput(string userInput, Scripture scripture)
    {
        if (string.IsNullOrWhiteSpace(userInput))
        {
            HandleWordHiding(scripture);
        }
        else if (userInput.Length == 1)
        {
            // The user can guess about the hidden words using one letter at a time.
            scripture.GuessWithLetter(userInput);
        }
    }

    static void HandleWordHiding(Scripture scripture)
    {
        // The user can hide words from the ones that are not hidden.
        Random random = new();
        int shownWordsCount = Math.Min(scripture.GetShownWords().Count, 4);
        int randomAmount = random.Next(1, shownWordsCount);

        scripture.HideRandomWords(randomAmount);
    }
}