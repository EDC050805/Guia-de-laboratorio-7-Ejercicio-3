// See https://aka.ms/new-console-template for more information
Console.WriteLine("\tPrograma para mostrar todos los años bisiestos desde 1900");
Console.WriteLine("\t---------------------------------------------------------\n");
Console.WriteLine("Años bisiestos: \n");
int contador = 1;

for (float i = 1900; i <= 2023; i++)
{
    if (((i % 4 == 0) & (i % 100 == 0) & (i % 400 == 0)) || ((i % 4 == 0) & (i % 100 != 0)))
    {
        Console.WriteLine($"Año {contador}: {i}");
        contador++;
    }
}

    
