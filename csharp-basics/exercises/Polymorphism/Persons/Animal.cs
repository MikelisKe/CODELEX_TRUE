namespace Persons
{
    public abstract class Animal
    {
        public string _animalName;
        public double _animalWeight;
        public int _foodEaten;

        public Animal(string animalName, double animalWeight, int foodEaten)
        {
            _animalName = animalName;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
        }

        public abstract void MakeSound();


        public abstract void Eat(Food food, int count);
       
        public override string ToString()
        {
            return $"{this.GetType().Name} {_animalName} {_animalWeight}";
        }
    }
}