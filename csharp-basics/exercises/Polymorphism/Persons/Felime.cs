namespace Persons
{
    public abstract class Felime:Mammal
    {
        protected Felime(string animalName, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalWeight, foodEaten, livingRegion)
        {
        }

        public override string ToString()
        {
            return $"{_animalName} {_animalWeight}";
        }
    }
}
