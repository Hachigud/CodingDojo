class Samurai : Human{

    public Samurai() :base("Samurai",25,1,20,200){

    }


    
    public override int Attack(Human target)
    {
       base.Attack(target);
       if(target.Health <50){
        target.Health = 0;
       }
        return target.Health;
    }

    public void Meditate(){
        Health  = 200;
    }

}