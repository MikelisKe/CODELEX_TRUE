using System;

namespace Persons
{
    public class Mouse : Mammal

    {
    public Mouse(string animalName, double animalWeight, int foodEaten, string livingRegion) : base(
        animalName, animalWeight, foodEaten, livingRegion)
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine("Piik.. Piik.");
    }

    public override void Eat(Food food, int count)
    {
        if (food is Meat)
        {
            Console.WriteLine("are not eating that type of food!");
            return;
        }
        _foodEaten += food._quantity;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} {_animalName} {_animalWeight}";
    }
    }
}