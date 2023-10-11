class Ninja : Human{
    public Ninja() :base("Ninja",10,5,75,70){

    }


       public override int Attack(Human target)
    {
        int dmg;
        Random random = new Random();
        int randomNum = random.Next(1,5);
        if(randomNum == 1){
            double dmgPercent = (Dexterity * 3) * 0.2;
            dmg = (Dexterity * 3) + (int)dmgPercent;
        }else{
            dmg = Dexterity * 3;
        }
        
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        
        return target.Health;
    }

        public  int Steal(Human target)
    {
        int dmg = 5;
        target.Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Health += dmg;
        return target.Health;
    }
}