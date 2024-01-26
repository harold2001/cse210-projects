using System;

class Program
{
    static void Main(string[] args)
    {
        Reference newReference = new("Proverbs", 3, 5, 6);
        Scripture scripture = new(newReference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        string answer;
        do
        {
            scripture.GetDisplayText();

            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            answer = Console.ReadLine();

            if (answer == "")
            {
                Random random = new();
                int shownWordsCount = Math.Min(scripture.GetShownWords().Count, 3);
                int randomAmount = random.Next(1, shownWordsCount);
                scripture.HideRandomWords(randomAmount);
                Console.Clear();
            }

        } while (answer != "quit" && !scripture.IsCompletelyHidden());
    }
}