class Jugador{
    private string Nombre;
    private List<Carta> Mano;


    public Jugador(string Nombre){
        Mano = new List<Carta>();
        this.Nombre = Nombre;
    }




public Carta Robo(Mazo mazo){
    Random rand = new Random();
    int randomNum = rand.Next(0,mazo._cartas.Count-1);
    Mano.Add(mazo._cartas[randomNum]);
    Carta robada =  mazo._cartas[randomNum];
    mazo._cartas.RemoveAt(randomNum);
    return (robada);
}

public Carta Descartar(int indice){
    if(Mano.Count < indice){
        return null;
    }else{
        Carta cartaEliminada = Mano[indice];
        Mano.RemoveAt(indice); 
        return  cartaEliminada;
    }
}



  public string _Nombre
    {
        get { return Nombre; }
        set { Nombre = value; }
    }

  public List<Carta> _Mano
    {
        get { return Mano; }
        set { Mano = value; }
    }

}