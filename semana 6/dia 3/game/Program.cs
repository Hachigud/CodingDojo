Wizard mago = new Wizard();
Ninja ninja = new Ninja();
Samurai samurai = new Samurai();
Zombie zombie = new Zombie();
Zombie zombie2 = new Zombie();
Spider spider = new Spider();
Random rand = new Random();
Console.Write("En una Mazmorra no muy un equipo conformado por 1 mago 1 ninja y 1 samurai se encuentran en una dificil situacion, debes ganar esta pelea! \n");

do{


    string jugador = null;
    string acciones = null;
    string objetivo = null;
    do{
        Console.Write("Seleccione el personaje : \n 1.- Mago  \n 2.- Ninja \n 3.- Samurai \n");
        jugador = Console.ReadLine();
        if(jugador != "1" && jugador != "2" && jugador != "3"){
            Console.Write("Personaje no valido seleccionelo nuevamente \n");
        }
        while((jugador =="1" &&mago.Health <= 0) ||( jugador == "2" && ninja.Health <= 0 ) || (jugador =="3" && samurai.Health <= 0)){
          Console.Write("Ese jugador se encuentra muerto seleccione otro \n"); 
          jugador = Console.ReadLine();
        }
        
    }while(jugador != "1" && jugador != "2" && jugador != "3");
    do{

        Console.Write("Acciones!:\n 1.- Atacar  \n 2.- Habilidad \n");
         acciones = Console.ReadLine();
        if(acciones != "1" && acciones != "2"){
        Console.Write("Accion no valida seleccionela nuevamente!");
        }
        

    }while(acciones != "1" && acciones != "2");
    do{
        Console.Write("Selecciona tu objetivo:\n 1.- Zombie 1  \n 2.- Araña \n 3.- Zombie 2 \n");
        objetivo = Console.ReadLine();
         if(objetivo != "1" && objetivo != "2" && objetivo != "3"){
         Console.Write("Objetivo no valido seleccionelo nuevamente \n");
        }
            while((objetivo=="1" && zombie.Health <= 0) || (objetivo =="2" && spider.Health <= 0) || ( objetivo=="3" && zombie2.Health <= 0)){
            Console.Write("Ese objetivo se encuentra muerto seleccione otro \n");
            objetivo = Console.ReadLine();
        }

    }while(objetivo != "1" && objetivo != "2" && objetivo != "3");

    if(jugador == "1"){
        if(acciones == "1"){
            if(objetivo == "1"){
                mago.Attack(zombie);
            }else if(objetivo == "2"){
                mago.Attack(spider);
            }else{
                mago.Attack(zombie2);
            }
        }else{
            if(objetivo == "1"){
              mago.Heal(mago); 
            }else if(objetivo == "2"){
                mago.Heal(ninja); 
            }else{
                mago.Heal(samurai);          
            }
        }
    }else if(jugador == "2"){
          if(acciones == "1"){
            if(objetivo == "1"){
                ninja.Attack(zombie);
            }else if(objetivo == "2"){
                ninja.Attack(spider);
            }else{
                ninja.Attack(zombie2);
            }
        }else{
            if(objetivo == "1"){
                ninja.Steal(zombie);
            }else if(objetivo == "2"){
                ninja.Steal(spider);
            }else{
                ninja.Steal(zombie2);   
            }
        }

    }else{
        if(acciones == "1"){
            if(objetivo == "1"){
                samurai.Attack(zombie);
            }else if(objetivo == "2"){
                samurai.Attack(spider);
            }else{
                samurai.Attack(zombie2);
            }
        }else{
            samurai.Meditate();
        } 
    }


int randomNum = rand.Next(1,3);
if(randomNum == 1){
    if(zombie.Health > 0){
        if(mago.Health <= 0){
            Console.Write("El zombie  ataca al mago que yace muerto (Cuando estava vivo odiaba la magia)\n");
        }
        zombie.Attack(mago);
    }else{
        Console.Write("\n El zombie Esta muerto no puede atacar\n");
    }
    if(spider.Health> 0){
        if(ninja.Health <= 0){
            Console.Write("La araña  ataca al ninja que yace muerto (Quien es el mas rapido ahora!)\n");
        }
        spider.Attack(ninja);
    }else{
        Console.Write("\n La araña Esta muerta no puede atacar\n");
    }
    if(zombie2.Health>0){
        if(samurai.Health <= 0){
            Console.Write("El zombie 2 ataca al zamurai que yace muerto (Supongo que odia a los samurais XD)\n");
        }
        zombie2.Attack(samurai);
    }else{
        Console.Write("\n El zombie2 Esta muerto no puede atacar\n");
    }
       
}
if(randomNum == 2){
    if(zombie.Health > 0){
        if(ninja.Health <= 0){
            Console.Write("El zombie   ataca al ninja que yace muerto (Eso es por su brazo!)\n");
        }
       zombie.Attack(ninja); 
    }else{
        Console.Write("\n El zombie Esta muerto no puede atacar\n");
    }
    if(spider.Health> 0){
        if(samurai.Health <= 0){
            Console.Write("La araña ataca al zamurai que yace muerto (Esta poniendo huevos en su cuerpo! QUE ASCO)\n");
        }
        spider.Attack(samurai);
    }else{
        Console.Write("\n La araña Esta muerta no puede atacar\n");
    }
    if(zombie2.Health>0){
        if(mago.Health <= 0){
            Console.Write("El zombie 2  ataca al mago que yace muerto (Quiere sustraerle el mana para revivir?)\n");
        }
         zombie2.Attack(mago);
    }else{
        Console.Write("\n El zombie2 Esta muerto no puede atacar\n");
    }
    
    
   
}
if(randomNum == 3){
    if(zombie.Health > 0){
        if(samurai.Health <= 0){
            Console.Write("El zombie ataca al zamurai que yace muerto (Creo que le gusto su carne! LOL)\n");
        }
        zombie.Attack(samurai);
    }else{
        Console.Write("\n El zombie Esta muerto no puede atacar\n");
    }
    if(spider.Health> 0){
        if(mago.Health <= 0){
            Console.Write("La araña  ataca al mago que yace muerto (Supongo que no le gusta la magia)\n");
        }
        spider.Attack(mago);
    }else{
        Console.Write("\n La araña Esta muerta no puede atacar\n");
    }
    if(zombie2.Health>0){
        if(ninja.Health <= 0){
            Console.Write("El zombie 2  ataca al ninja que yace muerto (Ahora no eres tan rapido eh!)\n");
        }
         zombie2.Attack(ninja);
    }else{
        Console.Write("\n El zombie2 Esta muerto no puede atacar\n");
    }
}

if(zombie.Health<=0){
    Console.Write("\nEl zombie intenta volver a la vida Con su habilidad No Muerto\n");
    zombie.NoMuerto();
}
if(zombie2.Health<=0){
    Console.Write("\nEl zombie intenta volver a la vida Con su habilidad No Muerto\n");
    zombie2.NoMuerto();
}

Console.Write("\n Turno jugado stats actuales \n");
Console.Write($"HP Mago : {mago.Health} \n");
Console.Write($"HP Ninja : {ninja.Health} \n");
Console.Write($"HP Samurai : {samurai.Health} \n");
Console.Write($"HP Zombie : {zombie.Health} \n");
Console.Write($"HP Araña : {spider.Health} \n");
Console.Write($"HP Zombie 2 : {zombie2.Health} \n");

}while((zombie.Health > 0 || spider.Health > 0 || zombie2.Health >= 0) && (mago.Health > 0 || ninja.Health > 0 || samurai.Health > 0));



if(zombie.Health <= 0 && spider.Health <= 0 && zombie2.Health <= 0){
    Console.Write("\n FELICIDADES venciste la mazmorra \n  *Sonidos de trompeta*");
}else{
    Console.Write("\n Haz muerto en la mazmorra \n  *Sonidos de mazmorra Buuuu*");
}