class Wizard : Human{


    public Wizard() :base("wizard",5,25,5,50){

    }


    public override int Attack(Human target)
    {
        int dmg = Intelligence * 3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Health += dmg;
        return target.Health;
    }

       public  int Heal(Human target)
    {
        int heal = Intelligence * 3;
        target.Health += heal;
        Console.WriteLine($"{Name} healed {target.Name} for {heal} HP!");
        return target.Health;
    }
}