using System;

abstract class Person
{
    protected string _name;
    protected int _age;

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public abstract string DisplayInfo();
}