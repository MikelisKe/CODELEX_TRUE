using System;

namespace Persons
{

    public class Cat : Felime
    {

        public string _breed;

        public Cat(string animalName, double animalWeight, int foodEaten, string livingRegion, string breed) :
            base(animalName, animalWeight, foodEaten, livingRegion)
        {
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meaw..");
        }

        public override void Eat(Food food, int count)
        {
            _foodEaten += food._quantity;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} {_animalName} {_animalWeight}";
        }
    }
}