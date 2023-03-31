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
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (food is null)
            {
                throw new ArgumentNullException();
            }
            if (food is Meat)
            {
                throw new ArgumentException();
            }
            _foodEaten += food._quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} {_animalName} {_animalWeight} {_livingRegion}";
        }
    }
}