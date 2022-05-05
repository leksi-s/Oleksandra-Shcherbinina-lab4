class Parrot : Bird
{
    public Parrot(string name, string description, int years, int weight) : base(name, description, years, weight)
    {
        Name = name;
        Description = description;
        Years = years;
        Weight = weight;
    }

}