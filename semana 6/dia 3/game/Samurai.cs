class Samurai : Human{

    public Samurai() :base("Samurai",25,1,20,200){

    }


    
    public override int Attack(Enemy target)
    {
       base.Attack(target);
       if(target.Health <50){
        target.Health = 0;
       }
        return target.Health;
    }

    public void Meditate(){
        Health  += 200;
        Console.Write("\n El samurai medita curando su vida en 200HP \n");
    }

}