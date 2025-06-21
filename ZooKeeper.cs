// OOP

public class ZooKeeper
{
    private string _name;

    public ZooKeeper(string name)
    {
        _name = name;
    }

    public void FeedAllAnimals(List<Animal> animals)
    {
        Console.WriteLine($"{_name} is starting the feeding round...\n");

        foreach (var animal in animals)
        {
            Console.WriteLine($"Feeding {animal.Name}");
            animal.Feed();
            Console.WriteLine();
        }

        Console.WriteLine($"{_name} has finished feeding all the animals.");
    }
}
