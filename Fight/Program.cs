int TylerHp = 100;
int BobHp = 100;

string fighter1 = "TYLER";

Console.WriteLine("Välkommen till Fight Club!");
Console.WriteLine("Skriv ditt namn.");
string fighter2 = Console.ReadLine();

Random generator = new Random();

while (TylerHp > 0 && BobHp > 0)
{
    Console.WriteLine("\n----- ===== NY RUNDA ===== -----");
    Console.WriteLine($"{fighter1}: {TylerHp}  {fighter2}: {BobHp}\n");

    Console.ReadKey();

    int tylerDamage = generator.Next(20);
    BobHp -= tylerDamage;
    BobHp = Math.Max(0, BobHp);
    Console.WriteLine($"{fighter1} gör {tylerDamage} skada på {fighter2}");

    int bobDamage = generator.Next(20);
    TylerHp -= bobDamage;
    TylerHp = Math.Max(0, TylerHp);
    Console.WriteLine($"{fighter2} gör {bobDamage} skada på {fighter1}");

    Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
    Console.ReadKey();
}

if (TylerHp == 0 && BobHp == 0)
{
    Console.WriteLine("OAVGJORT");
}
else if (TylerHp == 0)
{
    Console.WriteLine($"{fighter2} vann!");
}
else
{
    Console.WriteLine($"{fighter1} vann!");
}



Console.ReadKey();