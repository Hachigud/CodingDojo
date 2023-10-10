// 1. Imprimir 1-255​

static void PrintNumbers()
{
    for (int i = 1; i <= 255; i++)
    {
        Console.Write(i + " ");
    }
}

PrintNumbers();
Console.Write("\n");
// Imprimir números impares entre 1-255​
static void PrintOdds()
{
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            Console.Write(i + " ");
        }

    }
}

PrintOdds();
Console.Write("\n");
//3.-  Imprimir Suma​
static void PrintSum()
{
     for (int i = 0; i <= 255; i++)
    {
        Console.Write("Numero actual: "+ i + " Suma : " + (i+(i-1)) +" ");
    }
}

PrintSum();
Console.Write("\n");
//4.- Iterar a través de una matriz​
static void LoopArray(int[] numbers)
{
    for (int i = 0; i <numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
}
int[] arrayNumbers = new int[]{1,2,3,4,5,6};
LoopArray(arrayNumbers);
Console.Write("\n");
//5.- Encuentra el valor máximo
static int FindMax(int[] numbers)
{
    int max = numbers[0];
   for (int i = 1; i <numbers.Length; i++)
    {
        if(numbers[i]> max){
            max = numbers[i];
        }
        
    }
    return max;
}

int valorMax = FindMax(arrayNumbers);
Console.Write($"el valor Maximo es {valorMax}");
Console.Write("\n");

//6.- Obtén el Promedio​

static void GetAverage(int[] numbers){
int sum = 0;

   for (int i = 0; i <numbers.Length; i++)
    {
        sum += numbers[i];
    }
 Console.Write($"El promedio de los valores en la lista es {(float)sum/numbers.Length}");   
}

GetAverage(arrayNumbers);
Console.Write("\n");

//7.- Lista con números impares​
static List<int> OddList()
{
    List<int> listaOdd = new List<int>();
    for (int i =1; i<=255;i++){
        if(i % 2 != 0){
            listaOdd.Add(i);
        }
    }
    return listaOdd;
}

List<int> miListaOdd = OddList();
foreach(int iterador in miListaOdd){
    Console.Write(iterador +" ");
}
Console.Write("\n");

//8.- Mayor que Y​
List<int> listNumbers = new List<int>();
listNumbers.Add(1);
listNumbers.Add(2);
listNumbers.Add(3);
listNumbers.Add(4);
listNumbers.Add(5);
static int GreaterThanY(List<int> numbers, int y)
{
   int contador = 0;
   for(int i = 0; i < numbers.Count; i++){
    if(numbers[i]>y){
        contador ++;
    }
   }
   return contador;
}

int contadorGreater = GreaterThanY(listNumbers,3);
Console.Write($"Hay un total de {contadorGreater} numeros mayores");
Console.Write("\n");

//9.-Haz Cuadrar los Valores​
static void SquareArrayValues(List<int> numbers)
{
     for(int i = 0; i < numbers.Count; i++){    
        numbers[i] = numbers[i] * numbers[i];
   }

    foreach(int iterador in numbers){
        Console.Write(iterador + " ");
    }
}

SquareArrayValues(listNumbers);
Console.Write("\n");

//10.- Elimina los Números Negativos​
static void EliminateNegatives(List<int> numbers)
{
    for(int i = 0; i < numbers.Count; i++){    
        if(numbers[i]<0){
            numbers[i] = 0;
        }
   }
    foreach(int iterador in numbers){
        Console.Write(iterador + " ");
    }
}
List<int> listNumbers2 = new List<int>();
listNumbers2.Add(1);
listNumbers2.Add(-2);
listNumbers2.Add(3);
listNumbers2.Add(4);
listNumbers2.Add(-5);
EliminateNegatives(listNumbers2);
Console.Write("\n");
