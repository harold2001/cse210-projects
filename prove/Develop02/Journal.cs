using System;
using System.Collections.Generic;

class Journal
{
    readonly List<Entry> _entries = new();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saving entries ...");

        try
        {
            using StreamWriter sw = new(filename);
            foreach (Entry entry in _entries)
            {
                sw.WriteLine($"{entry._promptText}\t{entry._entryText}");
            }

            Console.WriteLine($"Entries saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving entries: {ex.Message}");
        }
        finally
        {
            Console.WriteLine();
        }
    }

    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Loading entries ...");

        try
        {
            using StreamReader sr = new(filename);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] values = line.Split('\t');

                if (values.Length == 2)
                {
                    string prompt = values[0];
                    string answer = values[1];

                    Entry loadedEntry = new(prompt, answer);
                    AddEntry(loadedEntry);
                }
            }

            Console.WriteLine($"Entries loaded from {filename}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File {filename} not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading entries: {ex.Message}");
        }
        finally
        {
            Console.WriteLine();
        }
    }
}

