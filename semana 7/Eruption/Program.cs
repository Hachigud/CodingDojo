List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 

Eruption firstChile = eruptions.First(e => e.Location == "Chile");
Console.WriteLine("primera erupcion en chile" + firstChile.ToString());

Eruption firstHawai = eruptions.FirstOrDefault(e => e.Location == "Hawaiian Is");
if(firstHawai == null){
    Console.WriteLine("No Hawaiian Is Eruption found.");
}else{
    Console.WriteLine("primera erupcion en Hawai" + firstChile.ToString());
}


IEnumerable<Eruption> firstNewZeland = eruptions.Where(e => e.Location == "New Zealand");
Eruption NewZeland1900 = firstNewZeland.FirstOrDefault(e => e.Year > 1900);
Console.WriteLine("primera erupcion en New Zealand en 1900+" + NewZeland1900.ToString());


IEnumerable<Eruption> elevation2000 = eruptions.Where(e => e.ElevationInMeters > 2000);
PrintEach(elevation2000, "Elevation over 2000.");

IEnumerable<Eruption> vulcanoL = eruptions.Where(e => e.Volcano.StartsWith("L"));
int totalvulcanoL = vulcanoL.Count();
PrintEach(vulcanoL, $"Volcanes con L Total: {totalvulcanoL}");


int maximo = eruptions.Max(e => e.ElevationInMeters);
Console.Write($"La altura maxima es : {maximo}");

Eruption volcanoMaximo = eruptions.FirstOrDefault(e => e.ElevationInMeters == maximo);
Console.Write(" Datos del volcan ");
Console.Write(volcanoMaximo.ToString());



IEnumerable<Eruption> alfabetico = eruptions.OrderBy(e => e.Volcano);
PrintEach(alfabetico, $"Volcanes alfabeticamente");



IEnumerable<Eruption> alfAño = eruptions.Where(e => e.Year < 1000);
IEnumerable<Eruption> aflAñoOrden = alfAño.OrderBy(e => e.Volcano);
PrintEach(aflAñoOrden, "volcanes año 1000 - orden alfabetico");


// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}



