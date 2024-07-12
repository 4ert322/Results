namespace _123;

internal class Crocodile
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
