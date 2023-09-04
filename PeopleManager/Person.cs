using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; private set; }

    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int Zipcode { get; set; }
    public Person(string name, int age, string address, string city, string state, int zipcode)
    {
        Name = name;
        Age = age;
        Address = address;
        City = city;
        State = state;
        Zipcode = zipcode;
    }
    public int CompareTo(Person other)
    {
        return Name.CompareTo(other.Name);
    }

    public void HaveABirthday()
    {
        Age++;
    }

    public void Display()
    {
        Console.WriteLine(ToString());
    }

    public void Move()
    {
        Console.WriteLine($"You are moving address for {Name}");
        Console.WriteLine("Enter new address");
        Address = Console.ReadLine();
        Console.WriteLine("Enter new city");
        City = Console.ReadLine();
        Console.WriteLine("Enter new state");
        State = Console.ReadLine();
        Console.WriteLine("Enter new zipcode");
        string input = Console.ReadLine();
        Zipcode = int.Parse(input);
    }

    public override string? ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}
