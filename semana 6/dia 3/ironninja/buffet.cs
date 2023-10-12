class Buffet
{
    public List<IConsumable> Menu;
     
    public Buffet()
    {
        Menu = new List<IConsumable>()
        {
            new Food("Rice", 500, false, false),
            new Food("Spice Rice", 600, true, false),
            new Food("Fries", 1200, false, false),
            new Food("Spagetti", 800, false, false),
            new Food("Hambuerger", 800, false, false),
            new Food("Ice cream", 600, true, false),
            new Food("Rice with egg", 700, false, false),
            new Drink("Coca", 100, true, false),
            new Drink("Pepsi", 120, true, false),
            new Drink("Spicy Drink", 110, false, true)
       
    };
    }
     
    public IConsumable Serve()
    {
        Random rand = new Random();
        int randomNum = rand.Next(1,Menu.Count);
        return Menu[randomNum];
    }


    public void ListarMenu(){
        foreach(IConsumable iterador in Menu){ 
            Console.Write($"Nombre plato : {iterador.Name} \n Calorias: {iterador.Calories} \n Es picante: {iterador.IsSpicy} \n Es dulce: {iterador.IsSweet} \n");
            Console.Write("--------------------------------- \n");
        }
    }
    
}

