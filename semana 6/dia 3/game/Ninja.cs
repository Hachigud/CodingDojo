class Ninja : Human{
    public Ninja() :base("Ninja",10,5,75,70){

    }


       public override int Attack(Enemy target)
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

        public  int Steal(Enemy target)
    {
        int dmg = 15;
        target.Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage! And healed is self for {dmg*2}");
        Health += dmg*2;
        return target.Health;
    }
}