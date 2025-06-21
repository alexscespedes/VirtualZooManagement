// OOP

Animal lion = new Lion("Leo");
Animal elephant = new Elephant("Ella");
Animal parrot = new Parrot("Polly");

List<Animal> zooAnimals = new List<Animal> { lion, elephant, parrot };

foreach (var animal in zooAnimals)
{
    Console.WriteLine($"--- {animal.Name} ---");
    animal.MakeSound();
    animal.Feed();
    Console.WriteLine("");
}