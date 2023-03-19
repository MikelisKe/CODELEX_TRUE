using System;

namespace Persons
{
    public class Tiger:Felime
    {
        private string _livingTigerRegion;
        public Tiger(string animalName , double animalWeight, int foodEaten, string livingRegion, string livingTigerRegion) : base(animalName, animalWeight, foodEaten, livingRegion)
        {
            _livingTigerRegion = livingTigerRegion;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Rawr");
        }

        public override void Eat(Food food, int count)
        {
            if (food is Vegetable)
            {
                Console.WriteLine("are not eating that type of food!");
                return;
            }
            _foodEaten += food._quantity;
        }
    }
}