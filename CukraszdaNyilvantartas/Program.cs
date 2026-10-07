using CukraszdaNyilvantartas;

List<Sutemeny> sutik = new List<Sutemeny>();

for (int i = 0; i < 4; i++)
{
    Sutemeny aktualis= new Sutemeny();
    Console.WriteLine($"{i+1}. sütemény adatai:");
    Console.Write($"\tNév: ");
    aktualis.Nev = Console.ReadLine();

    Console.Write($"\tEgységár (Ft): ");
    aktualis.Egysegar = int.Parse(Console.ReadLine());

    Console.Write($"\tRaktáron (db): ");
    aktualis.RaktaonDb = int.Parse(Console.ReadLine());
    Console.WriteLine();

    sutik.Add( aktualis );
    
}

//4.1feladat

Console.WriteLine("Pultban lévő sütemények:");
int listdb= sutik.Count;
int teljes = 0;
double arak = 0;
for (int i = 0;i <listdb; i++)
{
    int osszeg = 0;
    osszeg += sutik[i].Egysegar * sutik[i].RaktaonDb;
    Console.WriteLine($"\t- {sutik[i].Nev}: {sutik[i].Egysegar} Ft / db({sutik[i].RaktaonDb} db) ->Öszzérték: {osszeg} Ft");
    teljes += osszeg;
    arak += sutik[i].Egysegar;
}
//4.2feladat
Console.WriteLine($"\nPult teljes készletértéke: {teljes} Ft");
double atlag = arak/listdb;
Console.WriteLine($"Sütemények átlagos egységára: {atlag} Ft");