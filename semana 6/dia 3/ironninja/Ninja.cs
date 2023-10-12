abstract class Ninja
{
    protected int calorieIntake{get;set;}
    public List<IConsumable> ConsumptionHistory{get;set;}
    public Ninja()
    {
        calorieIntake = 0;
        ConsumptionHistory = new List<IConsumable>();
    }
    public abstract bool IsFull {get;set;}
    public abstract void Consume(IConsumable item);


    

}

