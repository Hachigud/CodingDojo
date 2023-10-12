class Zombie : Enemy{

    public int Contador;  
    public Zombie() :base("Zombie",10,1,1,400){
        Contador = 0;
    }


    
    public override int Attack(Human target)
    {
       base.Attack(target);
       if(target.Health >Health){
        target.Health = 0;
       }
        return target.Health;
    }

    public void NoMuerto(){
        if(Contador == 0){
            Health  = 100;
            Contador++;
            Console.Write("El zombie logra volver a la vida(supongo que eso hacen los zombies)");
        }else{
            Console.Write("La habilidad 'NO MUERTO' del zombie Fallo");
        }
        
    }


      public int _Contador
    {
        get { return Contador; }
        set { Contador = value; }
    }
}