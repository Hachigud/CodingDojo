class Carta{
    private string Nombre;
    private string Pinta;
    private int Valor;

    public Carta(string Nombre, string Pinta, int Valor ){
        this.Nombre = Nombre;
        this.Pinta = Pinta;
        this.Valor = Valor;
    }

    public void imprimirCarta(){
        Console.Write($"Nombre: {Nombre} \n Pinta: {Pinta} \n Valor: {Valor}");
    }



    public string _Nombre
    {
        get { return Nombre; }
        set { Nombre = value; }
    }

    public string _Pinta
    {
        get { return Pinta; }
        set { Pinta = value; }
    }

    public int _Valor
    {
        get { return Valor; }
        set { Valor = value; }
    }


}