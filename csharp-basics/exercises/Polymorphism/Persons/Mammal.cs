namespace Persons
{
    public abstract class Mammal: Animal
    {
        private string _livingRegion { get; set; }
        protected Mammal(string animalName, double animalWeight, int foodEaten,string livingRegion ) : base(animalName, animalWeight, foodEaten)
        {
            _livingRegion = livingRegion;
        }
    }
}