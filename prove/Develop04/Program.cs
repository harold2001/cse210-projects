using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        int response = int.Parse(Console.ReadLine());

        Console.Clear();

        if (response == 1)
        {
            BreathingActivity breathing = new("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            breathing.DisplayStartingMessage();
        }

        if (response == 2)
        {
            ReflectingActivity reflecting = new("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            reflecting.DisplayStartingMessage();
        }

        if (response == 3)
        {
            ListingActivity listing = new("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain time.");
            listing.DisplayStartingMessage();
        }

    }
}