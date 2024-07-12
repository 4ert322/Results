using System;
using System.Collections.Generic;

class Crocodile
{
    public string Name { get; }
    public double Weight { get; }
    public double Length { get; }
    public int Age { get; }
    public string Gender { get; }

    public Crocodile(string name, double weight, double length, int age, string gender)
    {
        Name = name;
        Weight = weight;
        Length = length;
        Age = age;
        Gender = gender;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Weight: {Weight} kg, Length: {Length} m, Age: {Age} years, Gender: {Gender}";
    }
}

class CrocodileService
{
    private List<Crocodile> crocodiles = new List<Crocodile>();

    public void CreateCrocodile(string name, double weight, double length, int age, string gender)
    {
        var crocodile = new Crocodile(name, weight, length, age, gender);
        crocodiles.Add(crocodile);
    }

    public void GetAllCrocodilesInfo()
    {
        foreach (var crocodile in crocodiles)
        {
            Console.WriteLine(crocodile);
        }
    }

    public void GetLongCrocodilesInfo(double minLength)
    {
        foreach (var crocodile in crocodiles)
        {
            if (crocodile.Length > minLength)
            {
                Console.WriteLine(crocodile);
            }
        }
    }

    public void GetOldestCrocodileInfo()
    {
        Crocodile oldestCrocodile = null;
        foreach (var crocodile in crocodiles)
        {
            if (oldestCrocodile == null || crocodile.Age > oldestCrocodile.Age)
            {
                oldestCrocodile = crocodile;
            }
        }
        if (oldestCrocodile != null)
        {
            Console.WriteLine("Oldest crocodile:");
            Console.WriteLine(oldestCrocodile);
        }
    }

    public void GetHeaviestCrocodileInfo()
    {
        Crocodile heaviestCrocodile = null;
        foreach (var crocodile in crocodiles)
        {
            if (heaviestCrocodile == null || crocodile.Weight > heaviestCrocodile.Weight)
            {
                heaviestCrocodile = crocodile;
            }
        }
        if (heaviestCrocodile != null)
        {
            Console.WriteLine("Heaviest crocodile:");
            Console.WriteLine(heaviestCrocodile);
        }
    }
}

class Program
{
    static void Main()
    {
        var crocodileService = new CrocodileService();
        crocodileService.CreateCrocodile("Spike", 300, 4.5, 20, "Male");
        crocodileService.CreateCrocodile("Lizzy", 250, 4.0, 15, "Female");

        Console.WriteLine("All crocodiles:");
        crocodileService.GetAllCrocodilesInfo();

        Console.WriteLine("\nLong crocodiles (length > 4.2 m):");
        crocodileService.GetLongCrocodilesInfo(4.2);

        crocodileService.GetOldestCrocodileInfo();
        crocodileService.GetHeaviestCrocodileInfo();
    }
}
