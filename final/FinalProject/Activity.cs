using System;

class Activity
{
    private string _name;
    private List<Person> _participants = new();

    public void AddParticipant(Person person)
    {
        _participants.Add(person);
    }

    public void DisplayInfo()
    {

    }
}