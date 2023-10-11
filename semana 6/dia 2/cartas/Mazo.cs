class Mazo
{
    public List<Carta> cartas;

    public Mazo()
    {
        cartas = new List<Carta>();

        for (int i = 1; i <= 4; i++)
        {
            string pinta = "";
            if (i == 1)
            {
                pinta = "Pica";
            }
            if (i == 2)
            {
                pinta = "Tréboles";
            }
            if (i == 3)
            {
                pinta = "Corazones";
            }
            if (i == 4)
            {
                pinta = "Diamantes";
            }
            for (int j = 1; j <= 13; j++)
            {
                string nombre = j.ToString();
                if(j == 1){
                    nombre = "As";
                }
                if(j==11){
                    nombre = "J";
                }
                if(j==12){
                    nombre = "Reina";
                }
                if(j == 13){
                    nombre = "Rey";
                }

                Carta carta = new Carta(nombre, pinta, j);
                cartas.Add(carta);
            }
        }
    }


    public void MostrarMazo()
    {
        foreach (Carta iterador in cartas)
        {
            Console.Write($"Nombre carta : {iterador._Nombre} \n Pinta carta: {iterador._Pinta} \n Valor carta: {iterador._Valor} \n");
        }
    }



  public List<Carta> _cartas
    {
        get { return cartas; }
        set { cartas = value; }
    }

}