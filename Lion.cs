public class Lion : Animal
{
    public Lion(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} roars loudly!");
    }

    public override void Feed()
    {
        Console.WriteLine($"{Name} is eating raw meat.");
    }
}