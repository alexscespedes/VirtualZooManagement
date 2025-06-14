public abstract class Animal
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Animal(string name)
    {
        _name = name;
    }

    // Abstract method that must be implemented by subclasses
    public abstract void MakeSound();

    // Virtual method that can be overridden
    public virtual void Feed()
    {
        Console.WriteLine($"{Name} is being fed.");
    }
}