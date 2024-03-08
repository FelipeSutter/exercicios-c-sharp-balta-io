using System.Globalization;

class Program
{

    public static void Main(string[] args)
    {
        Console.Clear();

        decimal valor = 10534.25m;

        Console.WriteLine(Math.Round(valor)); // para configurar a moeda de cada país
    }
}