
Buffet menu = new Buffet();
menu.ListarMenu();
SweetTooth sweetTooth = new SweetTooth();
SpiceHound spiceHound = new SpiceHound();

IConsumable comida = menu.Serve();

Console.Write("SweetTooth consume \n");
sweetTooth.Consume(comida);
comida = menu.Serve();
Console.Write("\nSpiceHound consume \n");
spiceHound.Consume(comida);

Console.Write("\n");

Console.Write("SweetTooth consume \n");
sweetTooth.Consume(comida);
comida = menu.Serve();
Console.Write("\nSpiceHound consume \n");
spiceHound.Consume(comida);

Console.Write("\n");

Console.Write("SweetTooth consume \n");
sweetTooth.Consume(comida);
comida = menu.Serve();
Console.Write("\nSpiceHound consume \n");
spiceHound.Consume(comida);

Console.Write("\n");

Console.Write("SweetTooth consume \n");
sweetTooth.Consume(comida);


int totalComidasSweet = sweetTooth.CalcularComidas();
int totalComidasSpice = spiceHound.CalcularComidas();
Console.Write($"\n SweetTooth consumio un total de {totalComidasSweet} platos . \n");
Console.Write($"\n SpiceHound consumio un total de {totalComidasSpice} platos . \n");

