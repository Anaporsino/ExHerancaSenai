using _02;

Porco porco1 = new Porco
{
    Especie = "Porco Doméstico"
};

porco1.EmitirSom();
Console.WriteLine($"Espécie: {porco1.Especie}");
Console.ReadKey();