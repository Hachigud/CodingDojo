class Spider : Enemy{
    public Spider() :base("Spider",20,5,100,100){

    }


       public override int Attack(Human target)
    {
        int dmg;
        Random random = new Random();
        int randomNum = random.Next(1,10);
        if(randomNum == 1){
            double dmgPercent = (Dexterity * 3) * 0.1;
            dmg = (Dexterity * 2) + (int)dmgPercent;
        }else{
            dmg = Dexterity * 2;
        }
        
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        
        return target.Health;
    }

        public  int Bite(Human target)
    {
        int dmg = 2;
        target.Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Health += (dmg*2);
        return target.Health;
    }
}