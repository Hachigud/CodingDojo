class SweetTooth : Ninja
{


    protected int calorieIntake {get;set;}
    public List<IConsumable> ConsumptionHistory{get;set;}
    

    public SweetTooth()
    {
        calorieIntake = 0;
        ConsumptionHistory = new List<IConsumable>();
        IsFull = false;
    }

    // provide override for IsFull (Full at 1500 Calories)
    public override bool IsFull{get;set;}

    public override void Consume(IConsumable item)
    {
       
        if(IsFull == true){
            Console.Write("SweetTooth está lleno y no puede comer más​");
        }else{
            calorieIntake += item.Calories;
            if(item.IsSweet == true){
                calorieIntake += 10;
            }
            if(calorieIntake>1500){
                IsFull = true;
            }
            ConsumptionHistory.Add(item);
            string consumio = item.GetInfo();
            Console.Write(consumio);
        }
    }

     public int CalcularComidas(){
        return ConsumptionHistory.Count;
    } 

   
}

