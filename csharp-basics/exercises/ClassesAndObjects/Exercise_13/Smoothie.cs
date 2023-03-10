using Exercise_13;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Exercise_13;

class Smoothie
{
    private readonly Dictionary<string, decimal> _prices = new Dictionary<string, decimal>
    {
        { "Strawberries", 1.50m },
        { "Banana", 0.50m },
        { "Mango", 2.50m },
        { "Blueberries", 1.00m },
        { "Raspberries", 1.00m },
        { "Apple", 1.75m },
        { "Pineapple", 3.50m }
    };

    public Smoothie(string[] ingredients)
    {
        Ingredients = ingredients;
    }

    public string[] Ingredients { get; }

    public string GetCost()
    {
        decimal cost = 0m;
        foreach (string ingredient in Ingredients)
        {
            if (_prices.ContainsKey(ingredient))
            {
                cost += _prices[ingredient];
            }
        }

        return $"£{cost:0.00}";
    }

    public string GetPrice()
    {
        decimal cost = decimal.Parse(GetCost().TrimStart('£'));
        decimal price = cost + cost * 1.5m;
        return $"£{price:0.00}";
    }

    public string GetName()
    {
        string[] sortedIngredients = Ingredients
            .Select(ingredient => ingredient.EndsWith("berries") ? ingredient.Replace("berries", "berry") : ingredient)
            .OrderBy(ingredient => ingredient)
            .ToArray();

        string name;
        if (sortedIngredients.Length == 1)
        {
            name = sortedIngredients[0] + " Smoothie";
        }
        else
        {
            name = string.Join(" ", sortedIngredients) + " Fusion";
        }
        return name;
    }
}
