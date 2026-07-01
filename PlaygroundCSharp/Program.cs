Console.WriteLine("============= Criador de Herói =============");

Console.Write("Nome: ");
string? nome = Console.ReadLine();
Console.Write("Força: ");
int forca = int.Parse(Console.ReadLine());
Console.Write("Agilidade: ");
int agilidade = int.Parse(Console.ReadLine());
Console.Write("Inteligência: ");
int inteligencia = int.Parse(Console.ReadLine());
int poderTotal = forca + agilidade + inteligencia;



Console.WriteLine("=============  HERÓI =============");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Força: {forca}");
Console.WriteLine($"Agliadade: {agilidade}");
Console.WriteLine($"Inteligência: {inteligencia}");
Console.WriteLine($"Poder Total --> {poderTotal}");
if (poderTotal <= 15)
{
    Console.WriteLine("Herói fraco ");
}
else if(poderTotal <= 21)
{
    Console.WriteLine("Herói médiano");
}
else
{
    Console.WriteLine("Herói forte");
}

Console.WriteLine("Obrigado por criar seu herói!");
Console.WriteLine("Boa aventura!");