public class Parrot : Animal
{
    public Parrot(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Hello! Hello!");
    }

    public override void Feed()
    {
        Console.WriteLine($"{Name} is pecking at seeds.");
    }
}