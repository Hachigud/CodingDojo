    class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;

    public bool isFull;
     
    public Ninja(){
        calorieIntake = 0;
        FoodHistory  = new List<Food>();
        isFull = false;
    }

    public Ninja(int calorieIntake, List<Food> FoodHistory, bool isFull){
        this.calorieIntake = calorieIntake;
        this.FoodHistory = FoodHistory;
        this.isFull = isFull;
    }
     
   
     
    
    public void Eat(Food item,Ninja ninja)
    {
        if(ninja._isFull == false){
            ninja._calorieIntake += item._Calories;
            ninja._FoodHistory.Add(item);
            item.datosComida();
        }else{
            Console.Write("El ninja ya no puede comer mas. \n");
        }

    }

    
    public int _calorieIntake
    {
        get { return calorieIntake; }
        set { calorieIntake = value; }
    }

     public List<Food> _FoodHistory
    {
        get { return FoodHistory; }
        set { FoodHistory = value; }
    }

    public bool _isFull
    {
        get { return isFull; }
        set { isFull = value; }
    }

    public void Historial(Ninja ninja){
        Console.Write(" Historial comidas: \n");
        foreach(Food i in ninja._FoodHistory){
            Console.Write($" {i._Name}  \n");
        }
    }
}

