
string nombre = "juan";
string nombre2 = "Pedro";
int Strength = 10;
int Intelligence =10;
int Dexterity = 10;
int Health = 200;
Human jugador  = new Human(nombre);
//jugador.ImprimeInformacion();
Human jugador2  = new Human(nombre2,Strength,Intelligence,Dexterity,Health);
//jugador2.ImprimeInformacion();

int vidaJugador = jugador.Attack(jugador2,jugador);
Console.Write("\n");
Console.Write($"Vida restante: {vidaJugador}");
Console.Write("\n");
int vidaJugador2 = jugador2.Attack(jugador,jugador2);
Console.Write("\n");
Console.Write($"Vida restante: {vidaJugador2}");


