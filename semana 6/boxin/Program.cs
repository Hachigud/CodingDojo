List<object> objeto = new List<object>();
objeto.Add(7);
objeto.Add(28);
objeto.Add(-1);
objeto.Add(true);
objeto.Add("chair");

int suma = 0;
foreach(object iterador in objeto){
    Console.Write(iterador + "\n");
    if(iterador is int){
        suma += (int)iterador;
    }
}

Console.Write(suma);