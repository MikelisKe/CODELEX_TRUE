using Exercise_6;

internal class DogTest
{
    public static void Main(string[] args)
    {
        Dog Max = new Dog("Max", "male");
        Dog Rocky = new Dog("Rocky", "male");
        Dog Sparky = new Dog("Sparky", "male");
        Dog Buster = new Dog("Buster", "male");
        Dog Sam = new Dog("Sam", "male");
        Dog Lady = new Dog("Lady", "female");
        Dog Molly = new Dog("Lady", "female");
        Dog Coco = new Dog("Lady", "female");

       
        Max.Mother = Lady;
        Max.Father = Rocky;
        Coco.Mother = Molly;
        Coco.Father = Buster;
        Rocky.Mother = Molly;
        Rocky.Father = Sam;
        Buster.Mother = Lady;
        Buster.Father = Sparky;

        Console.WriteLine(Coco.FathersName());
        Console.WriteLine(Sparky.FathersName());

        Console.WriteLine(Coco.HasSameMotherAs(Rocky)); 
        Console.WriteLine(Coco.HasSameMotherAs(Sparky));
    }
}
