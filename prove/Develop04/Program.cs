// My program has a validation for the elements inserted in the Listing Activity. Asks the user if the list they inserted is correct or not; and if so the program saves it; otherwise, the program prompts the user to enter a new list with the same message.

using System;

class Program
{
    static void Main(string[] args)
    {
        int response;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            response = int.Parse(Console.ReadLine());

            Console.Clear();

            if (response == 1)
            {
                BreathingActivity breathing = new("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.Run();
            }

            if (response == 2)
            {
                ReflectingActivity reflecting = new("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflecting.Run();
            }

            if (response == 3)
            {
                ListingActivity listing = new("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain time.");
                listing.Run();
            }

            if (response == 4)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        } while (response != 4);
    }
}