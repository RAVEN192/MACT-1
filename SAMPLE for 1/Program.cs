using System;
using System.Collections.Generic;
using System.Linq;

public class Smoothie
{
    static Dictionary<string, double> prices = new Dictionary<string, double>()
    {
        { "Strawberries", 60.00 },
        { "Banana", 20.00 },
        { "Mango", 50.00 },
        { "Blueberries", 80.00 },
        { "Raspberries", 100.00 },
        { "Apple", 60.00 },
        { "Pineapple", 100.00 }
    };

    public List<string> Ingredients { get; set; }

    public Smoothie(string[] ingredients)
    {
        Ingredients = ingredients.ToList();
    }

    public double GetCost()
    {
        double totalCost = 0;
        foreach (var ingredient in Ingredients)
        {
            if (prices.ContainsKey(ingredient))
            {
                totalCost += prices[ingredient];
            }
        }
        return totalCost;
    }

    public double GetPrice()
    {
        double cost = GetCost();
        return Math.Round(cost + (cost * 1.5), 2);
    }

    public string GetName()
    {
        Ingredients.Sort();
        string name = string.Join(" ", Ingredients);
        if (Ingredients.Count > 1)
        {
            name += " Fusion";
        }
        else
        {
            name += " Smoothie";
        }
        name = name.Replace("berries", "berry");
        return name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Smoothie s1 = new Smoothie(new string[] { "Banana" });
        Console.WriteLine("Ingredients: (" + string.Join(", ", s1.Ingredients) + ")");
        Console.WriteLine("Cost: P" + s1.GetCost().ToString("0.00"));
        Console.WriteLine("Price: P" + s1.GetPrice().ToString("0.00"));
        Console.WriteLine("Smoothie Name: "+ s1.GetName());

        Console.WriteLine();

        Smoothie s2 = new Smoothie(new string[] { "Strawberries" });
        Console.WriteLine("Ingredients: (" + string.Join(", ", s2.Ingredients) + ")");
        Console.WriteLine("Cost: P" + s2.GetCost().ToString("0.00"));
        Console.WriteLine("Price: P" + s2.GetPrice().ToString("0.00"));
        Console.WriteLine("Smoothie Name: "+ s2.GetName());

        Console.WriteLine();

        Smoothie s3 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
        Console.WriteLine("Ingredients: (" + string.Join(", ", s3.Ingredients) + ")");
        Console.WriteLine("Cost: P" + s3.GetCost().ToString("0.00"));
        Console.WriteLine("Price: P" + s3.GetPrice().ToString("0.00"));
        Console.WriteLine("Fused Name: "+ s3.GetName());

        Console.WriteLine();

        Smoothie s4 = new Smoothie(new string[] { "Pineapple", "Strawberries", "Blueberries", "Raspberries", "Apple", "Mango" });
        Console.WriteLine("Ingredients: (" + string.Join(", ", s4.Ingredients) + ")");
        Console.WriteLine("Cost: P" + s4.GetCost().ToString("0.00"));
        Console.WriteLine("Price: P" + s4.GetPrice().ToString("0.00"));
        Console.WriteLine("Fused Name: " + s4.GetName());

        Console.WriteLine();

        Smoothie s5 = new Smoothie(new string[] { "Raspberries" });
        Console.WriteLine("Ingredients: (" + string.Join(", ", s5.Ingredients) + ")");
        Console.WriteLine("Cost: P" + s5.GetCost().ToString("0.00"));
        Console.WriteLine("Price: P" + s5.GetPrice().ToString("0.00"));
        Console.WriteLine("Smoothie Name: " + s5.GetName());


    }
}
