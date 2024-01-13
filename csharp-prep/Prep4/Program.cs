using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = 0;
        int maxNumber = 0;
        int menorPositivo = int.MaxValue;

        if (numbers.Count > 0)
        {
            average = numbers.Average();
            maxNumber = numbers.Max();

            foreach (int number in numbers)
            {
                if (number > 0 && number < menorPositivo)
                {
                    menorPositivo = number;
                }
            }

            numbers.Sort();
        }

        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max number is: {maxNumber}");
        Console.WriteLine($"The smallest positive number is:: {menorPositivo}");

        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}