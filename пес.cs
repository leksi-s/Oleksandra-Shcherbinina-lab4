class Dog : Pet
{
    public Dog(string name, string description, int years, int weight)
    {
        Name = name;
        Description = description;
        Years = years;
        Weight = weight;
    }
    public override void Voice()
    {
        Console.WriteLine("гав");
    }
}