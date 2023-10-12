class Wizard : Human{


    public Wizard() :base("wizard",5,25,5,100){

    }


    public override int Attack(Enemy target)
    {
        int dmg = Intelligence * 3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage! and healed is self for {dmg/2}");
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