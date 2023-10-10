//1.- Matriz Aleatoria
Console.Write("Matriz aleatoria ------------------ \n");
static int[] RandomArray()
{
    Random rand = new Random();
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        int randomNum = rand.Next(5, 25);
        array[i] = randomNum;
    }

    return array;
}

static void MinAndMax(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    Console.Write($"El minimo es : {min} y el maximo es : {max}");

}

int[] myRandomArray = RandomArray();
Console.Write("\n");
foreach (int iterador in myRandomArray)
{
    Console.Write(iterador + " ");
}
Console.Write("\n");
MinAndMax(myRandomArray);
Console.Write("\n");

//2.- Lanzamiento de Moneda
Console.Write("Lanzamiento de Moneda ------------------ \n");
Console.Write("\n");

static string TossCoin()
{
    Console.Write("Tirando una moneda \n");
    Random rand = new Random();
    int randomNum = rand.Next(2);
    if (randomNum == 1)
    {
        Console.Write("Cara \n");
        return ("cara");
    }
    else
    {
        Console.Write("Cruz \n");
        return ("cruz");
    }
}
string moneda = TossCoin();
Console.Write($"La moneda quedo en {moneda}");
Console.Write("\n");


static double TossMultipleCoins(int num)
{
    int contadorCaras = 0;
    for (int i = 0; i < num; i++)
    {
        string resultado = TossCoin();
        if (resultado == "cara")
        {
            contadorCaras++;
        }
    }
    double proporcion = (double)contadorCaras / (double)num;

    return proporcion;
}
Console.Write("Lanzando varias monedas seguidas : \n");
double proporcion = TossMultipleCoins(10);

Console.Write($"La proporcion de caras es de : {proporcion}");
Console.Write("\n");


//2.- Nombres
Console.Write("Nombres ------------------ \n");
Console.Write("\n");

static List<string> nombres()
{
    List<string> nombres = new List<string>();
    nombres.Add("Todd");
    nombres.Add("Tiffany");
    nombres.Add("Charlie");
    nombres.Add("Ginebra");
    nombres.Add("Sydney");

    List<string> nombresMayores = new List<string>();
    
    for(int i = 0; i< nombres.Count; i++){
        if(nombres[i].Length > 5){
            nombresMayores.Add(nombres[i]);
        }
    }

    return nombresMayores;
}

List<string> miLista = new List<string>();
miLista = nombres();
foreach(string nombre in miLista){
    Console.Write(nombre+" ");
}


Console.Write("\n lista aleatorizada \n");
Random rand = new Random();
var listaRandom = miLista.OrderBy(_ => rand.Next()).ToList();
foreach(string nombre in listaRandom){
    Console.Write(nombre+" ");
}