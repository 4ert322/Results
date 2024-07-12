namespace _123;

internal class CrocodileService
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
            Console.WriteLine(heaviestCrocodile);
        }
    }
}
