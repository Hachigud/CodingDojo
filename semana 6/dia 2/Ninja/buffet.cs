class Buffet
{
    public List<Food> Menu;
     
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Rice", 500, false, false),
            new Food("Spice Rice", 600, true, false),
            new Food("Fries", 1200, false, false),
            new Food("Spagetti", 800, false, false),
            new Food("Hambuerger", 800, false, false),
            new Food("Ice cream", 600, true, false),
            new Food("Rice with egg", 700, false, false)
        };
    }
     
    public Food Serve()
    {
        Random rand = new Random();
        int randomNum = rand.Next(1,7);
        return Menu[randomNum];
    }


    public void ListarMenu(){
        foreach(Food iterador in Menu){ 
            Console.Write($"Nombre plato : {iterador._Name} \n Calorias: {iterador._Calories} \n Es picante: {iterador._IsSpicy} \n Es dulce: {iterador._IsSweet} \n");
            Console.Write("--------------------------------- \n");
        }
    }
}

