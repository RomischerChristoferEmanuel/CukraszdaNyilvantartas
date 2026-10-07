using CukraszdaNyilvantartas;

List<Sutemeny> sutik = new List<Sutemeny>();

for (int i = 0; i < 4; i++)
{
    Sutemeny aktualis= new Sutemeny();
    Console.WriteLine($"{i+1}. sütemény adatai:");
    Console.Write($"Név: ");
    aktualis.Nev = Console.ReadLine();

    Console.Write($"Egységár (Ft): ");
    aktualis.Egysegar = int.Parse(Console.ReadLine());

    Console.Write($"Raktáron (db): ");
    aktualis.RaktaonDb = int.Parse(Console.ReadLine());
    Console.WriteLine();





}