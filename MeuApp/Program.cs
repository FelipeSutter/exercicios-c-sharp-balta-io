class Program {

    static void Subtracao() {
        Console.WriteLine("Primeiro valor: ");
        float n1 = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Segundo valor: ");
        float n2 = float.Parse(Console.ReadLine() ?? "0");

        float resultado = n1 - n2;

        Console.WriteLine($"O resultado da subtracao eh: {resultado}");
        Console.ReadKey();
    }

    public static void Main(string[] args) {
        Subtracao();
        

    }

   
}