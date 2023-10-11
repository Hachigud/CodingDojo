class Food
{
    public string Name;
    public int Calories;
    public bool IsSpicy;
    public bool IsSweet;


    public Food(string Name, int Calories, bool IsSpicy, bool IsSweet){
        this.Name = Name;
        this.Calories = Calories;
        this.IsSpicy = IsSpicy;
        this.IsSweet = IsSweet;
    }




    public string _Name
    {
        get { return Name; }
        set { Name = value; }
    }

      public int _Calories
    {
        get { return Calories; }
        set { Calories = value; }
    }

      public bool _IsSpicy
    {
        get { return IsSpicy; }
        set { IsSpicy = value; }
    }

      public bool _IsSweet
    {
        get { return IsSweet; }
        set { IsSweet = value; }
    }

    public void datosComida(){
        Console.Write($"Nombre plato : {_Name} \n Calorias: {_Calories} \n Es picante: {_IsSpicy} \n Es dulce: {_IsSweet} \n");
    }


}

