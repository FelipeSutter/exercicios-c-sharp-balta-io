class Program {

    static void Somar() {

        Console.WriteLine("Primeiro valor: ");
        float n1 = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Segundo valor: ");
        float n2 = float.Parse(Console.ReadLine() ?? "0");

        float resultado = n1 + n2;

        Console.WriteLine($"O resultado da soma eh: {resultado}");
        Console.ReadKey();
    }

    static void Subtrair() {

        Console.WriteLine("Primeiro valor: ");
        float n1 = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Segundo valor: ");
        float n2 = float.Parse(Console.ReadLine() ?? "0");

        float resultado = n1 - n2;

        Console.WriteLine($"O resultado da subtracao eh: {resultado}");
        Console.ReadKey();
    }

    static void Multiplicar() {

        Console.WriteLine("Primeiro valor: ");
        float n1 = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Segundo valor: ");
        float n2 = float.Parse(Console.ReadLine() ?? "0");

        float resultado = n1 * n2;

        Console.WriteLine($"O resultado da multiplicacao eh: {resultado}");
        Console.ReadKey();
    }

    static void Dividir() {

        Console.WriteLine("Primeiro valor: ");
        float n1 = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Segundo valor: ");
        float n2 = float.Parse(Console.ReadLine() ?? "0");

        float resultado = n1 / n2;

        Console.WriteLine($"O resultado da divisao eh: {resultado}");
        Console.ReadKey();
    }

    static int Menu() {
        int opcao;
        do {
            Console.Clear();
            Console.WriteLine("Bem-vindo(a) à calculadora C-Sharp!\n");
            Console.WriteLine("1 - Adição\n");
            Console.WriteLine("2 - Subtração\n");
            Console.WriteLine("3 - Multiplicação\n");
            Console.WriteLine("4 - Divisão\n");
            Console.WriteLine("5 - Sair\n");
            Console.WriteLine("Escolha a sua opção: ");
            opcao = int.Parse(Console.ReadLine() ?? "1");
        } while (opcao < 1 || opcao > 5);
        return opcao;
    }

    public static void Main(string[] args) {

        bool isMenuActive = true;
        while(isMenuActive) {
            switch (Menu()) {
                case 1:
                    Somar();
                    break;
                case 2:
                    Subtrair();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                    Dividir();
                    break;
                case 5:
                    isMenuActive = false;
                    break;

            }
        }
    }


}