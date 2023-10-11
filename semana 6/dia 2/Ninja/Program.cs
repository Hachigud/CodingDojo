Buffet menu = new Buffet();
menu.ListarMenu();
Food comida = menu.Serve();





Ninja ninja = new Ninja();
Ninja ninja2 = new Ninja(10000,menu.Menu,true);


ninja.Eat(comida,ninja);
Console.Write("\n");
Console.Write($"El ninja1 comio {comida._Name} que tiene {comida._Calories} teniendo un total de {ninja._calorieIntake} calorias");
Console.Write("\n");
comida = menu.Serve();
ninja.Eat(comida,ninja);
Console.Write("\n");
Console.Write($"El ninja1 comio {comida._Name} que tiene {comida._Calories} teniendo un total de {ninja._calorieIntake} calorias");

Console.Write("\n");
Console.Write("El historial de comidas del ninja 1 es : \n");
ninja.Historial(ninja); 
Console.Write("\n");
Console.Write("El ninja 2 come : \n");
ninja2.Eat(comida,ninja2);
Console.Write($"Ya consumio un total de {ninja2._calorieIntake} calorias \n");