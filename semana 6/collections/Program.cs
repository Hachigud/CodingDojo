/* 1.- Crea una matriz para contener los valores enteros 0 a 9.​
Crea una matriz con los nombres "Tim", "Martin", "Nikki" y "Sara".​
Crea una matriz de longitud 10 que alterne entre valores verdadero y falso, empezando por verdadero.​

*/

int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

string[] nombres = new string[] {"Tim", "Martin", "Nikki" ,"Sara"};

bool[] datos = new bool[10];

for(int i = 0; i<datos.Length;i++){
   
    if(i % 2 == 0){
        datos[i] = true;
    }else{
        datos[i] = false;
    }
}

foreach(bool valores in datos){
    Console.Write(valores + " ");
}

Console.Write("\n");

/*2.- Crea una lista de sabores de helados que contenga al menos 5 sabores diferentes (¡no dudes en añadir más de 5!).​
Imprime la longitud de esta lista después de construirla. ​
Imprime el tercer sabor de la lista y luego elimina ese valor. ​
Obtén la nueva longitud de la lista (¡sólo debería ser una menos!)​ */

List<string> helados = new List<string>();
helados.Add("chocolate");
helados.Add("frutilla");
helados.Add("frambueza");
helados.Add("chirimolla");
helados.Add("crema");
helados.Add("limon");
Console.Write(helados.Count + "\n");
Console.Write(helados[2] + "\n");
helados.RemoveAt(2);
Console.Write(helados.Count + "\n");
foreach(string helado in helados){
    Console.Write(helado + " ");
}

/* 3.- Diccionario de Información del Usuario
Crea un diccionario que almacene tanto claves de cadena como valores de cadena. ​
Añade pares clave/valor a este diccionario donde:​
cada clave sea un nombre de la matriz de nombres​
cada valor sea un sabor seleccionado al azar de tu lista de sabores.​
Revisa el diccionario e imprime el nombre de cada usuario y su sabor de helado asociado.​
*/

Dictionary<string, string> usuario = new Dictionary<string, string>();
Console.Write("\n");
Random rand = new Random();

for(int i = 0; i< nombres.Length;i++){
    int randomNum = rand.Next(5);
    usuario.Add(nombres[i],helados[randomNum]);
}

foreach(KeyValuePair<string,string> dic in usuario){
    Console.Write(dic.Key + " " + dic.Value);
    Console.Write("\n");
}