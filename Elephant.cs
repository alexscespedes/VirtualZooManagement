public class Elephant : Animal
{
    public Elephant(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} trumpets!");
    }

    public override void Feed()
    {
        Console.WriteLine($"{Name} is munching on leaves and fruits.");
    }
}