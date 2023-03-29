using System;

namespace Persons
{
    public class Zebra:Mammal
    {
        public Zebra(string animalName, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalWeight, foodEaten, livingRegion)
        {

        }
        
        public override void MakeSound()
        {
            Console.WriteLine("Es neesmu zirgs!");
        }

        public override void Eat(Food food, int count)
        {
            if (food is null)
            {
                throw new ArgumentNullException();
            }
            if (food is Meat)
            {
                Console.WriteLine("are not eating that type of food!");
                return;
            }
            _foodEaten += food._quantity;
        }

    }
}