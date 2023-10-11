class Human
{
    // Properties for Human
    public string Name;
    public string _Name
     {
         get { return Name; }
         set { Name = value; }
     }
    public int Strength;

    public int _Strength
     {
         get { return Strength; }
         set { Strength = value; }
     }
    public int Intelligence;

    public int _Intelligence
     {
         get { return Intelligence; }
         set { Intelligence = value; }
     }
    public int Dexterity;

     public int _Dexterity
     {
         get { return Dexterity; }
         set { Dexterity = value; }
     }
    public int Health;

      public int _Health
     {
         get { return Health; }
         set { Health = value; }
     }
    
    public Human(string Name){
        this.Name = Name;
        Strength = 3;    
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }

    public Human(string Name,int Strength, int Intelligence, int Dexterity, int Health){
        this.Name = Name;
        this.Strength = Strength;    
        this.Intelligence = Intelligence;
        this.Dexterity = Dexterity;
        this.Health = Health;
    }
     
    
    public int Attack(Human target,Human atacante)
    {
        target._Health -= (atacante._Strength * 3);
        Console.Write($"El jugador {atacante._Name} ataco a {target._Name} haciendo {atacante._Strength * 3} de daño!");

        return(target._Health);
    }

      public void ImprimeInformacion(){
        Console.WriteLine($"Nombre: {Name}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Intelligence: {Intelligence}");
        Console.WriteLine($"Dexterity: {Dexterity}");
        Console.WriteLine($"Health: {Health}");
    }
}