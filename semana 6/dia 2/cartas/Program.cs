Carta carta = new Carta("As","Picas",1);
//carta.imprimirCarta();

Mazo mazo = new Mazo();
//mazo.MostrarMazo();

Jugador jugador = new Jugador("Juan");
Console.Write("-----------------------\n ");
Carta cartaRobada = jugador.Robo(mazo);
Console.Write($"Se robo la carta : Nombre : {cartaRobada._Nombre} -  Pinta: {cartaRobada._Pinta} - Valor: {cartaRobada._Valor}  \n");
Console.Write("-----------------------\n ");

cartaRobada = jugador.Robo(mazo);
Console.Write($"Se robo la carta : Nombre :{cartaRobada._Nombre} -  Pinta:{cartaRobada._Pinta} - Valor: {cartaRobada._Valor}  \n");
Console.Write("-----------------------\n ");

cartaRobada = jugador.Robo(mazo);
Console.Write($"Se robo la carta : Nombre : {cartaRobada._Nombre} - Pinta: {cartaRobada._Pinta} - Valor: {cartaRobada._Valor}  \n");
Console.Write("-----------------------\n ");

Console.Write("Mano del jugador \n  ---------------- \n");


foreach(Carta cartasJugador in jugador._Mano){
    Console.Write($"Carta: {cartasJugador._Nombre} - Pinta: {cartasJugador._Pinta} - Valor : {cartasJugador._Valor} \n");
}

Carta cartaDescartada = jugador.Descartar(1);

Console.Write($"La carta descartada es : {cartaDescartada._Nombre} - {cartaDescartada._Pinta} - {cartaDescartada._Valor} \n");
Console.Write("Mano del jugador \n  ---------------- \n");
foreach(Carta cartasJugador in jugador._Mano){
    Console.Write($"Carta: {cartasJugador._Nombre} - Pinta: {cartasJugador._Pinta} - Valor : {cartasJugador._Valor} \n");
}