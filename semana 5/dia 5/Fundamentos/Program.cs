// See https://aka.ms/new-console-template for more information


// TIPOS DE DATOS
Console.WriteLine("Hello, World!");
short edad = 15;
int habitantes = 123456;
long kilometros = 10000000000;

float nota = 6.5f;
double pi = 3.1416;

string nombre = "rafael";
char letra = 'a'; // estrictamente comillas simples

bool aprobado = true;


const float iva = 0.14f;





if(edad >=18){
    Console.WriteLine(nombre + " Si puedes manejar");
}else{
    int años = 18 - edad;
    Console.WriteLine(nombre + " No puedes manejar te faltan " + años + " años para manejar");
    Console.WriteLine($"{nombre} no tienes edad para manejar, te faltan {años} para poder hacerlo");  // string con formato ( permite agregar variables dentro mas facil)
}

Console.WriteLine("Me llamo {0}, tengo " + 28 + " años", "Tim");
Console.WriteLine($"Me llamo {0}, tengo " + 28 + " años", "Tim");

Random rand = new Random();
for(int val = 0; val < 10; val++)
{
    //Prints the next random value between 2 and 8
    Console.WriteLine(rand.Next(2,8));
}