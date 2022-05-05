abstract class Pet
{
    public string Name { get; set; }  
    public int Years { get; set; }
    public int Weight { get; set; }
    public string Description { get; set; }
    public abstract void Voice();

    public override string ToString()
    {
        return $"{Name}  {Years} y.o. {Weight} kg   {Description}";
    }
}

class HomePet
{
    public void Voice(Pet pet) { pet.Voice(); }
   
    public List<Pet> pets { get; set; }

    public HomePet()
    {
        pets = new List<Pet>();
    }

    public void AddPet()
    {
        Dog dog = new Dog("патрон", "не любить майонез", 5, 25);
        Cat cat = new Cat("мурка", "їсть вiскас на снiданок", 2, 10);
        Bird bird = new Bird("гриша", "хз", 2, 1);
        Parrot parrot = new Parrot("кеша", "вмiє говорити Слава Українi", 1, 1);
        
        pets.Add(dog); pets.Add(cat); pets.Add(bird); pets.Add(parrot);
    }

    public void Information()
    {
        foreach (var pts in pets)
        {
            Console.WriteLine(pts.ToString());
            Voice(pts);
        }

    }
}